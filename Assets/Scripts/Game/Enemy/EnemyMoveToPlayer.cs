using UnityEngine;
using ZombieLand.Game.Player;

namespace ZombieLand.Game.Enemy
{
    public class EnemyMoveToPlayer : MonoBehaviour
    {
        #region Variables

        [SerializeField] private EnemyMovement _enemyMovement;
        [SerializeField] private TriggerObserver _triggerObserver; 

        private Transform _playerTransform;

        #endregion


        #region Unity lifecycle

        private void Start()
        {
            _playerTransform = FindObjectOfType<PlayerHp>().transform;
            _triggerObserver.OnEntered += OnEntered;
            _triggerObserver.OnExited += OnExited;
        }

        private void OnEntered(Collider2D col)
        {
            SetTarget(_playerTransform);
        }

        private void OnExited(Collider2D other)
        {
            SetTarget(null);
        }

        #endregion


        #region Private methods

        private void SetTarget(Transform target)
        {
            _enemyMovement.SetTarget(target);
        }

        #endregion
    }
}