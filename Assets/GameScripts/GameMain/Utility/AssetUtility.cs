//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameFramework;

namespace Game.Main
{
    public static class AssetUtility
    {
        public static string GetAssetRootDirectory(string directory)
        {
            return Utility.Text.Format("Assets/GameRes/{0}", directory);
        }
        
        public static string GetConfigAsset(string assetName, bool fromBytes)
        {
            return Utility.Text.Format("Assets/GameRes/Configs/{0}.{1}", assetName, fromBytes ? "bytes" : "txt");
        }

        public static string GetDataTableAsset(string assetName, bool fromBytes)
        {
            return Utility.Text.Format("Assets/GameRes/DataTables/{0}.{1}", assetName, fromBytes ? "bytes" : "txt");
        }
        
        public static string GetLubanTableAsset(string assetName, bool fromBytes)
        {
            string typeName = fromBytes ? "bytes" : "json";
            string fileName = fromBytes ? "Bytes" : "JsonNoAB";
            return Utility.Text.Format("Assets/GameRes/LubanTables/{0}/{1}.{2}", fileName,assetName, typeName);
        }

        public static string GetDictionaryAsset(string assetName, bool fromBytes)
        {
            return Utility.Text.Format("Assets/GameRes/Localization/{0}/Dictionaries/{1}.{2}", GameEntry.Localization.Language.ToString(), assetName, fromBytes ? "bytes" : "xml");
        }

        public static string GetFontAsset(string assetName)
        {
            return Utility.Text.Format("Assets/GameRes/Fonts/{0}.ttf", assetName);
        }

        public static string GetSceneAsset(string assetName)
        {
            return Utility.Text.Format("Assets/GameRes/Scenes/{0}.unity", assetName);
        }

        public static string GetMusicAsset(string assetName)
        {
            return Utility.Text.Format("Assets/GameRes/Music/{0}.mp3", assetName);
        }

        public static string GetSoundAsset(string assetName)
        {
            return Utility.Text.Format("Assets/GameRes/Sounds/{0}.wav", assetName);
        }

        public static string GetEntityAsset(string assetName)
        {
            return Utility.Text.Format("Assets/GameRes/Entities/{0}.prefab", assetName);
        }

        public static string GetUIFormAsset(string assetName)
        {
            return Utility.Text.Format("Assets/GameRes/UI/UIForms/{0}.prefab", assetName);
        }

        public static string GetUISoundAsset(string assetName)
        {
            return Utility.Text.Format("Assets/GameRes/UI/UISounds/{0}.wav", assetName);
        }

        public static string GetHotDllAsset(string assetName)
        {
            return Utility.Text.Format("Assets/GameRes/HotAssemblies/HotDll/{0}.bytes", assetName);
        }

        public static string GetAOTDllAsset(string assetName)
        {
            return Utility.Text.Format("Assets/GameRes/HotAssemblies/AOT/{0}.bytes", assetName);
        }

        public static string GetModulePrefabsAsset(string assetName)
        {
            return Utility.Text.Format("Assets/GameRes/ModulePrefabs/{0}.prefab", assetName);
        }
    }
}
