// -----------------------------------------------
// Copyright © GameFramework. All rights reserved.
// CreateTime: 2022/8/9   17:24:6
// -----------------------------------------------

using System;
using Game.Main;

namespace Game.Hotfix
{
    /// <summary>
    /// 握手消息包
    /// </summary>
    public class SCHandshake : SCPacketBase
    {
        public override int Id
        {
            get
            {
                return 0;
            }
        }

        public override void Clear()
        {
            base.Clear();
        }
    }
}