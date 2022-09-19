using Unity.VisualScripting;
using UnityEngine;
using ZombieLand.Game.Player;

namespace ZombieLand.Game.Enemy.Attack
{
    public class EnemyMeleeAttack : EnemyAttack
    {
        #region Variables

        [SerializeField] private int _damage = 2;
        [SerializeField] private float _attackDelay;
        [SerializeField] private Transform _attackPoint;
        [SerializeField] private float _radius;
        [SerializeField] private LayerMask _layerMask;
        [SerializeField] private EnemyAnimation _enemyAnimation;

        [SerializeField] private float _delayTimer;

        #endregion


        #region Unity lifecycle
        
        #endregion

        #region Public methods

        protected override void InternalAttack()
        {
            _delayTimer = _attackDelay;
            Collider2D col = Physics2D.OverlapCircle(_attackPoint.position, _radius, _layerMask);

            if (col == null)
                return;

            PlayerHp playerHp = col.GetComponentInParent<PlayerHp>(); 
            _enemyAnimation.PlayAttack();
            if (playerHp != null)
            {
                playerHp.ApplyDamage(_damage);
            }
        }

        #endregion
    }
}