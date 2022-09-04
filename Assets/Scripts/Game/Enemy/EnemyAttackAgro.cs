using UnityEngine;

namespace ZombieLand.Game.Enemy
{
    public class EnemyAttackAgro : MonoBehaviour
    {
        #region Variables

        [SerializeField] private TriggerObserver _triggerObserver;
        [SerializeField] private EnemyAttack _enemyAttack;
        [SerializeField] private EnemyMovement _enemyMovement;

        private bool _isInRange;

        #endregion


        #region Unity lifecycle

        private void Start()
        {
            _triggerObserver.OnEntered += OnEntered;
            _triggerObserver.OnExited += OnExited;
        }

        private void Update()
        {
            if (_isInRange)
                _enemyAttack.Attack();
        }       

        #endregion


        #region Private methods

        private void OnExited(Collider2D col)
        {
            _isInRange = true;
            _enemyMovement.enabled = false;
        }

        private void OnEntered(Collider2D col)
        {
            _isInRange = false;
            _enemyMovement.enabled = true;
        }

        #endregion
    }
}