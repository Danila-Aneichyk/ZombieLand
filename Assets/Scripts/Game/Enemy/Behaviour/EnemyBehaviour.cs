using UnityEngine;

namespace ZombieLand.Game.Enemy.Behaviour
{
    public abstract class EnemyBehaviour : MonoBehaviour
    {
        #region Variables

        public bool IsActive { get; private set; }

        #endregion


        #region Unity lifecycle

        private void Update()
        {
            OnUpdate();

            if (IsActive)
                OnActiveUpdate();
        }

        public virtual void Activate()
        {
            IsActive = true;
        }

        public virtual void Deactivate()
        {
            IsActive = false;
        }

        protected virtual void OnUpdate() { }
        protected virtual void OnActiveUpdate() { }
    }

    #endregion
}