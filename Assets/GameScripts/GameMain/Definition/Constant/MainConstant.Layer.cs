// -----------------------------------------------
// Copyright © GameFramework. All rights reserved.
// CreateTime: 2023/11/26   10:44:55
// -----------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Main
{
    public static partial class MainConstant
    {
        /// <summary>
        /// 层。
        /// </summary>
        public static class Layer
        {
            public const string DefaultLayerName = "Default";
            public static readonly int DefaultLayerId = LayerMask.NameToLayer(DefaultLayerName);

            public const string UILayerName = "UI";
            public static readonly int UILayerId = LayerMask.NameToLayer(UILayerName);

            public const string TargetableObjectLayerName = "Targetable Object";
            public static readonly int TargetableObjectLayerId = LayerMask.NameToLayer(TargetableObjectLayerName);
        }
    }
}