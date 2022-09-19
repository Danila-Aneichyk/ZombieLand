using UnityEngine;

namespace ZombieLand.Game.Enemy
{
    public class EnemyAnimation : MonoBehaviour
    {
        #region Variables

        [SerializeField] private Animator _animator;

        #endregion


        #region Public methods

        public void PlayDeath()
        {
            _animator.SetTrigger("Death");
        }

        public void PlayAttack()
        {
            _animator.SetTrigger("Attack");
        }

        public void PlayWalk(float speed)
        {
            _animator.SetFloat("Speed", speed);
        }
        #endregion
    }
}