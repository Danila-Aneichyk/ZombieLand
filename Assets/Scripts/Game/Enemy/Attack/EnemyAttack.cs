using UnityEngine;
using ZombieLand.Game.Enemy.Behaviour;
using ZombieLand.Game.Player;

namespace ZombieLand.Game.Enemy.Attack
{
    public abstract class EnemyAttack : EnemyBehaviour
    {
        #region Variables

        private float _timer;
        private PlayerHp _playerHp;

        #endregion


        #region Unity lifecycle

        private void Start()
        {
            _playerHp = FindObjectOfType<PlayerHp>();
        }

        private void Update()
        {
            TickTimer();
        }

        #endregion


        protected override void OnUpdate()
        {
            base.OnUpdate();
            Attack();
        }


        #region Public methods

        private void Attack()
        {
            if (CanAttack())
                InternalAttack();
        }

        #endregion


        protected abstract void InternalAttack();


        #region Private methods

        private bool CanAttack() =>
            _timer <= 0 && _playerHp.CurrentHp > 0;

        private void TickTimer() =>
            _timer -= Time.deltaTime;

        #endregion
    }
}