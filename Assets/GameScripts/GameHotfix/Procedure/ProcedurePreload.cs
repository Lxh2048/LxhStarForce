//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
using GameEntry = Game.Main.GameEntry;
using UnityGameFramework.Runtime;
using System.Collections.Generic;
using Game.Main;
using GameFramework.Resource;
using GameFramework.Event;
using GameFramework;
using HybridCLR;
using Luban;
using SimpleJSON;
using UnityEngine;

namespace Game.Hotfix
{
    public class PrefabData
    {
        public string prefabName;
    }
    public class ProcedurePreload : ProcedureBase
    {
        private Dictionary<string, bool> m_LoadedFlag = new Dictionary<string, bool>();
        
        private Dictionary<string, TextAsset> m_LubanTextAssets = new Dictionary<string, TextAsset>();
        private Dictionary<string, byte[]> m_loadedHotifx = new Dictionary<string, byte[]>();

        public override bool UseNativeDialog
        {
            get
            {
                return false;
            }
        }

        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);

            GameEntry.Event.Subscribe(LoadConfigSuccessEventArgs.EventId, OnLoadConfigSuccess);
            GameEntry.Event.Subscribe(LoadConfigFailureEventArgs.EventId, OnLoadConfigFailure);
            GameEntry.Event.Subscribe(LoadDictionarySuccessEventArgs.EventId, OnLoadDictionarySuccess);
            GameEntry.Event.Subscribe(LoadDictionaryFailureEventArgs.EventId, OnLoadDictionaryFailure);

            m_LoadedFlag.Clear();

            PreloadResources();
        }

        protected override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
        {
            GameEntry.Event.Unsubscribe(LoadConfigSuccessEventArgs.EventId, OnLoadConfigSuccess);
            GameEntry.Event.Unsubscribe(LoadConfigFailureEventArgs.EventId, OnLoadConfigFailure);
            GameEntry.Event.Unsubscribe(LoadDictionarySuccessEventArgs.EventId, OnLoadDictionarySuccess);
            GameEntry.Event.Unsubscribe(LoadDictionaryFailureEventArgs.EventId, OnLoadDictionaryFailure);

            base.OnLeave(procedureOwner, isShutdown);
        }

        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

            foreach (KeyValuePair<string, bool> loadedFlag in m_LoadedFlag)
            {
                if (!loadedFlag.Value)
                {
                    return;
                }
            }
            
            // 注入luban
            // var table = new Cfg.Tables((file) => new ByteBuf(m_LubanTextAssets[file].bytes));
            var table = new Cfg.Tables((file) => JSON.Parse(m_LubanTextAssets[file].text));
            GameEntry.LubanTable.SetTables(table);
            m_LubanTextAssets.Clear();

            // aot元数据
            // if (!GameEntry.Base.EditorResourceMode)
            // {
            //     LoadMetadataForAOTAssemblies();
            // }

            ChangeState<ProcedureHybridCLRLaunch>(procedureOwner);
        }
        
        /// <summary>
        /// 为aot assembly加载原始metadata， 这个代码放aot或者热更新都行。
        /// 一旦加载后，如果AOT泛型函数对应native实现不存在，则自动替换为解释模式执行
        /// </summary>
        private void LoadMetadataForAOTAssemblies()
        {
            /// 注意，补充元数据是给AOT dll补充元数据，而不是给热更新dll补充元数据。
            /// 热更新dll不缺元数据，不需要补充，如果调用LoadMetadataForAOTAssembly会返回错误
            HomologousImageMode mode = HomologousImageMode.SuperSet;
            foreach (var aotDllName in Constant.AOTMetaNames)
            {
                byte[] dllBytes = m_loadedHotifx[aotDllName];
                // 加载assembly对应的dll，会自动为它hook。一旦aot泛型函数的native函数不存在，用解释器版本代码
                LoadImageErrorCode err = RuntimeApi.LoadMetadataForAOTAssembly(dllBytes, mode);
                Debug.Log($"LoadMetadataForAOTAssembly:{aotDllName}. mode:{mode} ret:{err}");
            }
        }

        private void PreloadResources()
        {
            // Preload configs
            LoadConfig("DefaultConfig");
            
            // Preload luban tables
            foreach (string lubanTableName in Constant.LubanTableNames)
            {
                LoadLubanTable(lubanTableName);
            }

            foreach (var packageName in Constant.FairyGUIPackages)
            {
                LoadFairyGUIPackage(packageName);
            }

            // Preload dictionaries
            LoadDictionary("Default");

            // Preload fonts
            LoadFont("MainFont");

            LoadModulePrefab("HP/HP Bar");

            // 加载 AOT 文件
            // if (!GameEntry.Base.EditorResourceMode)
            // {
            //     foreach (var aotDllName in Constant.AOTMetaNames)
            //     {
            //         LoadAOTDll(aotDllName);
            //     }
            // }
        }
        
        // private void LoadAOTDll(string aotName)
        // {
        //     m_LoadedFlag.Add(aotName, false);
        //     PrefabData prefabData = new PrefabData() { prefabName = aotName };
        //     string assetName = AssetUtility.GetAOTDllAsset(aotName);
        //     GameEntry.Resource.LoadAsset(assetName, new LoadAssetCallbacks(OnLoadAOTDllSuccess, OnLoadAOTFailured), prefabData);
        // }

        private void LoadConfig(string configName)
        {
            string configAssetName = AssetUtility.GetConfigAsset(configName, false);
            m_LoadedFlag.Add(configAssetName, false);
            GameEntry.Config.ReadData(configAssetName, this);
        }
        
        private void LoadLubanTable(string lubanTableName)
        {
            string lubanTableAssetName;
            // if (GameEntry.Base.EditorResourceMode)
            // {
            //     // 编辑器模式
            //     lubanTableAssetName = AssetUtility.GetLubanTableAsset(lubanTableName, false);
            // }
            // else
            // {
            //     lubanTableAssetName = AssetUtility.GetLubanTableAsset(lubanTableName, true);
            // }
            lubanTableAssetName = AssetUtility.GetLubanTableAsset(lubanTableName, false);
            m_LoadedFlag.Add(lubanTableAssetName, false);
            GameEntry.Resource.LoadAsset(lubanTableAssetName,new LoadAssetCallbacks((string assetName, object asset, float duration, object userData) =>
            {
                    m_LoadedFlag[assetName] = true;
                    m_LubanTextAssets.Add(lubanTableName, (TextAsset)asset);
            }, (string assetName, LoadResourceStatus status, string errorMessage, object userData) =>
            {
                Log.Error("Can not load luban table from '{0}' with error message '{1}'.", assetName, errorMessage);
            }));
        }

        private void LoadFairyGUIPackage(string packageName)
        {
            string packageAssetName = AssetUtility.GetFairyGuiPackages(packageName);
            m_LoadedFlag.Add(packageAssetName, false);
            GameEntry.Resource.LoadAsset(packageAssetName, new LoadAssetCallbacks(LoadBasicSuccessCallback));
        }

        private void LoadDictionary(string dictionaryName)
        {
            string dictionaryAssetName = AssetUtility.GetDictionaryAsset(dictionaryName, false);
            m_LoadedFlag.Add(dictionaryAssetName, false);
            GameEntry.Localization.ReadData(dictionaryAssetName, this);
        }

        private void LoadFont(string fontName)
        {
            m_LoadedFlag.Add(Utility.Text.Format("Font.{0}", fontName), false);
            GameEntry.Resource.LoadAsset(AssetUtility.GetFontAsset(fontName), Constant.AssetPriority.FontAsset, new LoadAssetCallbacks(
                (assetName, asset, duration, userData) =>
                {
                    m_LoadedFlag[Utility.Text.Format("Font.{0}", fontName)] = true;
                    UGUIForm.SetMainFont((Font)asset);
                    Log.Info("Load font '{0}' OK.", fontName);
                },

                (assetName, status, errorMessage, userData) =>
                {
                    Log.Error("Can not load font '{0}' from '{1}' with error message '{2}'.", fontName, assetName, errorMessage);
                }));
        }

        private void LoadModulePrefab(string perfabName)
        {
            m_LoadedFlag.Add(perfabName, false);
            PrefabData prefabData = new PrefabData() { prefabName = perfabName };
            string assetName = AssetUtility.GetModulePrefabsAsset(perfabName);
            GameEntry.Resource.LoadAsset(assetName, new LoadAssetCallbacks(OnLoadPerfabAssetSucceed, OnLoadPerfabAssetFailured), prefabData);
        }
        
        private void LoadBasicSuccessCallback(string assetName, object asset, float duration, object userData)
        {
            var fGuiAsset = asset as FairyGuiPackageAsset;
            fGuiAsset.Init();
            m_LoadedFlag[assetName] = true;
        }

        private void OnLoadConfigSuccess(object sender, GameEventArgs e)
        {
            LoadConfigSuccessEventArgs ne = (LoadConfigSuccessEventArgs)e;
            if (ne.UserData != this)
            {
                return;
            }

            m_LoadedFlag[ne.ConfigAssetName] = true;
            Log.Info("Load config '{0}' OK.", ne.ConfigAssetName);
        }

        private void OnLoadConfigFailure(object sender, GameEventArgs e)
        {
            LoadConfigFailureEventArgs ne = (LoadConfigFailureEventArgs)e;
            if (ne.UserData != this)
            {
                return;
            }

            Log.Error("Can not load config '{0}' from '{1}' with error message '{2}'.", ne.ConfigAssetName, ne.ConfigAssetName, ne.ErrorMessage);
        }

        private void OnLoadDictionarySuccess(object sender, GameEventArgs e)
        {
            LoadDictionarySuccessEventArgs ne = (LoadDictionarySuccessEventArgs)e;
            if (ne.UserData != this)
            {
                return;
            }

            m_LoadedFlag[ne.DictionaryAssetName] = true;
            Log.Info("Load dictionary '{0}' OK.", ne.DictionaryAssetName);
        }

        private void OnLoadDictionaryFailure(object sender, GameEventArgs e)
        {
            LoadDictionaryFailureEventArgs ne = (LoadDictionaryFailureEventArgs)e;
            if (ne.UserData != this)
            {
                return;
            }

            Log.Error("Can not load dictionary '{0}' from '{1}' with error message '{2}'.", ne.DictionaryAssetName, ne.DictionaryAssetName, ne.ErrorMessage);
        }

        private void OnLoadPerfabAssetSucceed(string assetName, object asset, float duration, object userData)
        {
            GameObject formPrefab = asset as GameObject;
            GameObject.Instantiate(formPrefab, GameEntry.Customs);
            PrefabData prefabData = userData as PrefabData;
            m_LoadedFlag[prefabData.prefabName] = true;
            formPrefab = null;
        }

        private void OnLoadPerfabAssetFailured(string assetName, LoadResourceStatus status, string errorMessage, object userData)
        {
            Log.Error("Can not load {0} from '{1}' with error message '{2}'.", assetName, "PerfabsAsset", errorMessage);
        }
        
        // private void OnLoadAOTDllSuccess(string assetName, object asset, float duration, object userData)
        // {
        //     PrefabData prefabData = userData as PrefabData;
        //     m_LoadedFlag[prefabData.prefabName] = true;
        //     m_loadedHotifx[prefabData.prefabName] = ((TextAsset)asset).bytes;
        // }
        //
        // private void OnLoadAOTFailured(string assetName, LoadResourceStatus status, string errorMessage, object userData)
        // {
        //     Log.Error("Can not load {0} from '{1}' with error message '{2}'.", assetName, "AOTAsset", errorMessage);
        // }
    }
}
