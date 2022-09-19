using UnityEngine;
using ZombieLand.Game.Enemy.Attack;
using ZombieLand.Game.Enemy.Hp;
using ZombieLand.Game.Enemy.Movement;

namespace ZombieLand.Game.Enemy.Death
{
    public class EnemyDeath : MonoBehaviour
    {
        #region Variables

        [SerializeField] private EnemyHp _enemyHp;
        [SerializeField] private EnemyMeleeAttack enemyMeleeAttack;
        [SerializeField] private EnemyAttackAgro _enemyAttackAgro;
        [SerializeField] private EnemyDirectMovement enemyDirectMovement;
        [SerializeField] private EnemyAnimation _enemyAnimation;
        [SerializeField] private EnemyMoveToPlayer _enemyMoveToPlayer;
        

        #endregion


        #region Properties

        private bool IsDead { get; set; }

        #endregion


        #region Unity lifecycle

        private void Start()
        {
            _enemyHp.OnChanged += OnHpChanged; 
        }

        #endregion


        #region Private methods

        private void OnHpChanged(int hp)
        {
            if (IsDead || hp > 0)
                return;
            Debug.Log("Enemy died");
            IsDead = true; 
            _enemyAnimation.PlayDeath();
            enemyMeleeAttack.enabled = false;
            enemyDirectMovement.enabled = false;
            _enemyAttackAgro.enabled = false;
            _enemyMoveToPlayer.enabled = false;
        }

        #endregion
    }
}