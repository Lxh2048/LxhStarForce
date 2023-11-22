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
    public class WeaponData : AccessoryObjectData
    {
        [SerializeField]
        private int m_Attack = 0;

        [SerializeField]
        private float m_AttackInterval = 0f;

        [SerializeField]
        private int m_BulletId = 0;

        [SerializeField]
        private float m_BulletSpeed = 0f;

        [SerializeField]
        private int m_BulletSoundId = 0;

        public WeaponData(int entityId, int typeId, int ownerId, CampType ownerCamp)
            : base(entityId, typeId, ownerId, ownerCamp)
        {
            if (GameEntry.LubanTable.TryGetTables(out Cfg.Tables tables))
            {
                var tbWeapon = tables.TbWeapon.Get(typeId);
                if (tbWeapon == null)
                {
                    return;
                }

                m_Attack = tbWeapon.Attack;
                m_AttackInterval = tbWeapon.AttackInterval;
                m_BulletId = tbWeapon.BulletId;
                m_BulletSpeed = tbWeapon.BulletSpeed;
                m_BulletSoundId = tbWeapon.BulletSoundId;
            }
        }

        /// <summary>
        /// 攻击力。
        /// </summary>
        public int Attack
        {
            get
            {
                return m_Attack;
            }
        }

        /// <summary>
        /// 攻击间隔。
        /// </summary>
        public float AttackInterval
        {
            get
            {
                return m_AttackInterval;
            }
        }

        /// <summary>
        /// 子弹编号。
        /// </summary>
        public int BulletId
        {
            get
            {
                return m_BulletId;
            }
        }

        /// <summary>
        /// 子弹速度。
        /// </summary>
        public float BulletSpeed
        {
            get
            {
                return m_BulletSpeed;
            }
        }

        /// <summary>
        /// 子弹声音编号。
        /// </summary>
        public int BulletSoundId
        {
            get
            {
                return m_BulletSoundId;
            }
        }
    }
}
