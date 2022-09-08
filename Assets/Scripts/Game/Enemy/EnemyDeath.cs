using System;
using UnityEngine;

namespace ZombieLand.Game.Enemy
{
    public class EnemyDeath : MonoBehaviour
    {
        #region Variables

        [SerializeField] private EnemyHp _enemyHp;
        [SerializeField] private EnemyAttack _enemyAttack;
        [SerializeField] private EnemyAttackAgro _enemyAttackAgro;
        [SerializeField] private EnemyMovement _enemyMovement;
        [SerializeField] private EnemyAnimation _enemyAnimation;
        [SerializeField] private EnemyMoveToPlayer _enemyMoveToPlayer;
        

        #endregion


        #region Properties 

        public bool IsDead { get; private set; }

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
            IsDead = true; 
            _enemyAnimation.PlayDeath();
            _enemyAttack.enabled = false;
            _enemyMovement.enabled = false;
            _enemyAttackAgro.enabled = false;
            _enemyMoveToPlayer.enabled = false;
        }

        #endregion
    }
}