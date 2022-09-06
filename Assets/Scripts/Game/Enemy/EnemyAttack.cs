using UnityEngine;
using ZombieLand.Game.Player;

namespace ZombieLand.Game.Enemy
{
    public class EnemyAttack : MonoBehaviour
    {
        #region Variables

        [SerializeField] private int _damage = 2; 
        [SerializeField] private float _attackDelay;
        [SerializeField] private Transform _attackPoint;
        [SerializeField] private float _radius;
        [SerializeField] private LayerMask _layerMask;

        [SerializeField] private float _delayTimer;

        #endregion


        #region Unity lifecycle

        private void Update()
        {
            TickTimer();
        }

        #endregion


        #region Private methods

        private void TickTimer()
        {
            _delayTimer -= Time.deltaTime;
        }

        #endregion


        #region Public methods

        public void Attack()
        {
            if (CanAttack())
                AttackInternal();
        }

        private bool CanAttack() =>
            _delayTimer <= 0;

        private void AttackInternal()
        {
            _delayTimer = _attackDelay;
            Collider2D col = Physics2D.OverlapCircle(_attackPoint.position, _radius, _layerMask);
            if (col == null)
                return;

            PlayerHp playerHp = col.GetComponentInParent<PlayerHp>(); 
            if (playerHp != null)
            {
                playerHp.ApplyDamage(_damage); 
            }
            Debug.Log("Enemy attack");
        }

        #endregion
    }
}