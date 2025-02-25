using UnityEngine;

using Scripts.Model.Attack;
using Scripts.Model.Health;
using Scripts.Model.Interfaces;

namespace Scripts.Model.Basement
{
    public class BasementBuilder : MonoBehaviour,IDamageable,IHealable
    {
        [SerializeField]private LayerMask _enemyLayer;
        [SerializeField]private int _stageRadius;

        private BasementGrader _basementGrader;

        private AttackBase _attackBase;
        private HealthBase _healthBase;

        
        internal void Init()
        {

        }


        public void GetDamage(uint value) => _healthBase.GetDamage((int)value);

        public void GetHeal(uint value) => _healthBase.GetHeal((int)value);
    }
}