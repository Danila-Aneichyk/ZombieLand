using UnityEngine;

namespace ZombieLand.Game.Enemy
{
    public class EnemyAnimation : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        public void PlayDeath()
        {
            _animator.SetTrigger("Death");
        }
    }
}