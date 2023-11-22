//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameFramework.DataTable;
using GameEntry = Game.Main.GameEntry;
using UnityEngine;
using System;
using Game.Main;

namespace Game.Hotfix
{
    [Serializable]
    public class AsteroidData : TargetableObjectData
    {
        [SerializeField]
        private int m_MaxHP = 0;

        [SerializeField]
        private int m_Attack = 0;

        [SerializeField]
        private float m_Speed = 0f;

        [SerializeField]
        private float m_AngularSpeed = 0f;

        [SerializeField]
        private int m_DeadEffectId = 0;

        [SerializeField]
        private int m_DeadSoundId = 0;

        public AsteroidData(int entityId, int typeId) : base(entityId, typeId, CampType.Neutral)
        {
            if (!GameEntry.LubanTable.TryGetTables(out Cfg.Tables tables)) return;
            var tbAsteroid = tables.TbAsteroid.Get(TypeId);
            if (tbAsteroid == null)
            {
                return;
            }

            HP = m_MaxHP = tbAsteroid.MaxHP;
            m_Attack = tbAsteroid.Attack;
            m_Speed = tbAsteroid.Speed;
            m_AngularSpeed = tbAsteroid.AngularSpeed;
            m_DeadEffectId = tbAsteroid.DeadEffectId;
            m_DeadSoundId = tbAsteroid.DeadSoundId;
        }

        public override int MaxHP
        {
            get
            {
                return m_MaxHP;
            }
        }

        public int Attack
        {
            get
            {
                return m_Attack;
            }
        }

        public float Speed
        {
            get
            {
                return m_Speed;
            }
        }

        public float AngularSpeed
        {
            get
            {
                return m_AngularSpeed;
            }
        }

        public int DeadEffectId
        {
            get
            {
                return m_DeadEffectId;
            }
        }

        public int DeadSoundId
        {
            get
            {
                return m_DeadSoundId;
            }
        }
    }
}
