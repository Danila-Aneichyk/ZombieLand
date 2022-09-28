using System;
using UnityEngine;

namespace ZombieLand.Game.Enemy.Patrol
{
    public class TriggerObserver : MonoBehaviour
    {
        public event Action<Collider2D> OnEntered;
        public event Action<Collider2D> OnStayed;
        public event Action<Collider2D> OnExited;

        private void OnTriggerEnter2D(Collider2D col) =>
            OnEntered?.Invoke(col);

        private void OnTriggerStay2D(Collider2D other) =>
            OnStayed?.Invoke(other);

        private void OnTriggerExit2D(Collider2D other) =>
            OnExited?.Invoke(other);
    }
}