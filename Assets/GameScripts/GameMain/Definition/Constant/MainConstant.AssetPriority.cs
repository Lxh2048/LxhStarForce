// -----------------------------------------------
// Copyright © GameFramework. All rights reserved.
// CreateTime: 2023/11/25   23:44:21
// -----------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Main
{
    public static partial class MainConstant
    {
        /// <summary>
        /// 资源优先级。
        /// </summary>
        public static class AssetPriority
        {
            public const int ConfigAsset = 100;
            public const int DataTableAsset = 100;
            public const int DictionaryAsset = 100;
            public const int FontAsset = 50;
            public const int MusicAsset = 20;
            public const int SceneAsset = 0;
            public const int SoundAsset = 30;
            public const int UIFormAsset = 50;
            public const int UISoundAsset = 30;

            public const int MyAircraftAsset = 90;
            public const int AircraftAsset = 80;
            public const int ThrusterAsset = 30;
            public const int WeaponAsset = 30;
            public const int ArmorAsset = 30;
            public const int BulletAsset = 80;
            public const int AsteroiAsset = 80;
            public const int EffectAsset = 80;
            public const int ScriptsAsset = 0;
        }
    }
}