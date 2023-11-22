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
    public class ArmorData : AccessoryObjectData
    {
        [SerializeField]
        private int m_MaxHP = 0;

        [SerializeField]
        private int m_Defense = 0;

        public ArmorData(int entityId, int typeId, int ownerId, CampType ownerCamp)
            : base(entityId, typeId, ownerId, ownerCamp)
        {
            if (!GameEntry.LubanTable.TryGetTables(out Cfg.Tables tables)) return;
            var tbArmor = tables.TbArmor.Get(TypeId);
            if (tbArmor == null)
            {
                return;
            }

            m_MaxHP = tbArmor.MaxHP;
            m_Defense = tbArmor.Defense;
        }

        /// <summary>
        /// 最大生命。
        /// </summary>
        public int MaxHP
        {
            get
            {
                return m_MaxHP;
            }
        }

        /// <summary>
        /// 防御力。
        /// </summary>
        public int Defense
        {
            get
            {
                return m_Defense;
            }
        }
    }
}
