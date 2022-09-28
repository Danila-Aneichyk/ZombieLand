using UnityEngine;

namespace ZombieLand.Game.Enemy
{
    public class EnemyAnimation : MonoBehaviour
    {
        #region Variables

        [SerializeField] private Animator _animator;
        private static readonly int IsAttack = Animator.StringToHash("IsAttack");
        private static readonly int Speed = Animator.StringToHash("Speed");

        #endregion


        #region Public methods

        public void PlayDeath()
        {
            _animator.SetTrigger("Death");
        }

        public void PlayAttack() =>
            _animator.SetTrigger(IsAttack);
        public void SetSpeed(float speed)
        {
            _animator.SetFloat(Speed, speed);
        }

        #endregion
    }
}