using UnityEngine;

namespace ZombieLand.Game.Enemy
{
    public class EnemyAnimation : MonoBehaviour
    {
        #region Variables

        [SerializeField] private Animator _animator;
        private static readonly int Attack = Animator.StringToHash("Attack");
        private static readonly int Speed = Animator.StringToHash("Speed");

        #endregion


        #region Public methods

        public void PlayDeath()
        {
            _animator.SetTrigger("Death");
        }

        public void PlayAttack() =>
            _animator.SetTrigger(Attack);
        public void SetSpeed(float speed)
        {
            _animator.SetFloat(Speed, speed);
        }

        #endregion
    }
}