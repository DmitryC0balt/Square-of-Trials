using UnityEngine;

namespace Scripts.Model.Attack
{
    public abstract class AttackBase
    {
        private bool _isReady;

        private LayerMask _enemyLayer;

        private Transform _target;
        
        protected Transform _firePoint;
        

        internal AttackBase()
        {

        }


        internal void Process()
        {
            if (!_isReady)
            {
                return;
            }
            AttackRealization();
        }

        protected abstract void AttackRealization();

        private bool Search(out Transform target)
        {
            target = null;
            return false;
        }


        private void Reload()
        {

        }


    }
}

