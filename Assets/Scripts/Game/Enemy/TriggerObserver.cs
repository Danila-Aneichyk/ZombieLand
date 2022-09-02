using System;
using UnityEngine;

namespace ZombieLand.Game.Enemy
{
    public class TriggerObserver : MonoBehaviour
    {
        #region Events

        public event Action<Collider2D> OnEntered;
        public event Action<Collider2D> OnExited;

        #endregion


        #region Unity lifecycle

        private void OnTriggerEnter2D(Collider2D col)
        {
            OnEntered?.Invoke(col);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            OnExited?.Invoke(other);
        }

        #endregion
    }
}