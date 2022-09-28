using UnityEngine;

namespace ZombieLand.Game.Enemy.Attack
{
    public class EnemyAttackMediator : MonoBehaviour
    {
        [SerializeField] private EnemyMeleeAttack _meleeAttack;

        public void PerformDamage()
        {
            _meleeAttack.PerformDamage();
        }
    }
}