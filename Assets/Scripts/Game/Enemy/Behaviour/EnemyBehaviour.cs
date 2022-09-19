using UnityEngine;

namespace ZombieLand.Game.Enemy.Behaviour
{
    public abstract class EnemyBehaviour : MonoBehaviour
    {
        #region Variables

        private bool _isActive;

        #endregion


        #region Unity lifecycle

        private void Update()
        {
            if (_isActive)
                OnUpdate();
        }

        public virtual void Activate()
        {
            _isActive = true;
        }

        public virtual void Deactivate()
        {
            _isActive = false;
        }

        protected virtual void OnUpdate()
        {
        }

        #endregion
    }
}