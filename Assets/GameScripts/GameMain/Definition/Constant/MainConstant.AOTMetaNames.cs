// -----------------------------------------------
// Copyright © GameFramework. All rights reserved.
// CreateTime: 2023/11/26   15:8:47
// -----------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Main
{
    public static partial class MainConstant
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