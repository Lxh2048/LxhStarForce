//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameEntry = Game.Main.GameEntry;
using GameFramework.DataTable;
using UnityEngine;
using System;
using Game.Main;

namespace Game.Hotfix
{
    [Serializable]
    public class ThrusterData : AccessoryObjectData
    {
        [SerializeField]
        private float m_Speed = 0f;

        public ThrusterData(int entityId, int typeId, int ownerId, CampType ownerCamp)
            : base(entityId, typeId, ownerId, ownerCamp)
        {
            if (!GameEntry.LubanTable.TryGetTables(out Cfg.Tables tables)) return;
            var tbThruster = tables.TbThruster.Get(TypeId);
            if (tbThruster == null)
            {
                return;
            }

            m_Speed = tbThruster.Speed;
        }

        /// <summary>
        /// 速度。
        /// </summary>
        public float Speed
        {
            get
            {
                return m_Speed;
            }
        }
    }
}
