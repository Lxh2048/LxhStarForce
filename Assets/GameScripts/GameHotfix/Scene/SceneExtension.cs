// -----------------------------------------------
// Copyright © GameFramework. All rights reserved.
// CreateTime: 2021/5/26   14:13:27
// -----------------------------------------------

using Game.Hotfix.Cfg;
using Game.Main;
using GameEntry = Game.Main.GameEntry;
using UnityGameFramework.Runtime;
using GameFramework.DataTable;

namespace Game.Hotfix
{
    public static class SceneExtension 
    {
        public static void AddLoadScene(this SceneComponent sceneComponent, int sceneId, object userData = null)
        {
            if (!GameEntry.LubanTable.TryGetTables(out Cfg.Tables tables)) return;
            var tbScene = tables.TbScene.Get(sceneId);
            if (tbScene == null)
            {
                Log.Warning("Can not load scene '{0}' from data table.", sceneId.ToString());
                return;
            }
            sceneComponent.LoadScene(AssetUtility.GetSceneAsset(tbScene.AssetName), Constant.AssetPriority.SceneAsset, userData);
        }
        public static void AddLoadScene(this SceneComponent sceneComponent, string sceneName, object userData = null)
        {
            if (!GameEntry.LubanTable.TryGetTables(out Cfg.Tables tables)) return;
            var tbScene = tables.TbScene.DataList;
            Scene scene = null;
            foreach (var s in tbScene)
            {
                if (s.AssetName != sceneName) continue;
                scene = s;
                break;
            }

            if (scene == null)
            {
                Log.Warning("Can not load scene '{0}' from data table.", sceneName);
                return;
            }
            sceneComponent.LoadScene(AssetUtility.GetSceneAsset(scene.AssetName), Constant.AssetPriority.SceneAsset, userData);
        }

        public static void UnLoadScene(this SceneComponent sceneComponent, string sceneName, object userData = null)
        {
            if (!GameEntry.LubanTable.TryGetTables(out Cfg.Tables tables)) return;
            var tbScene = tables.TbScene.DataList;
            Scene scene = null;
            foreach (var s in tbScene)
            {
                if (s.AssetName != sceneName) continue;
                scene = s;
                break;
            }

            if (scene == null)
            {
                Log.Warning("Can not load scene '{0}' from data table.", sceneName);
                return;
            }
            sceneComponent.UnloadScene(AssetUtility.GetSceneAsset(scene.AssetName), userData);
        }
        public static void UnLoadScene(this SceneComponent sceneComponent, int sceneId, object userData = null)
        {
            if (!GameEntry.LubanTable.TryGetTables(out Cfg.Tables tables)) return;
            var tbScene = tables.TbScene.Get(sceneId);
            if (tbScene == null)
            {
                Log.Warning("Can not load scene '{0}' from data table.", sceneId.ToString());
                return;
            }
            sceneComponent.UnloadScene(AssetUtility.GetSceneAsset(tbScene.AssetName), userData);
        }
    }
}