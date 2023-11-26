// -----------------------------------------------
// Copyright © GameFramework. All rights reserved.
// CreateTime: 2023/11/26   13:38:11
// -----------------------------------------------

using GameEntry = Game.Main.GameEntry;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace Game.Hotfix
{
    public static partial class Constant
    {
        /// <summary>
        /// AOT补充集。
        /// </summary>
        public static readonly string[] AOTMetaNames = new string[]
        {
            "GameFramework.dll",
            "System.dll",
            "UnityEngine.CoreModule.dll",
            "UnityGameFramework.Runtime.dll",
            "mscorlib.dll",
            "Game.Main.dll",
            
            // "System.Core.dll",
        };
    }
}