using UnityEngine;
using ZombieLand.Game.Enemy.Follow;
using ZombieLand.Game.Player;

namespace ZombieLand.Game.Enemy.Movement
{
    public class EnemyMoveToPlayer : EnemyFollow
    {
        [SerializeField] private EnemyMovement _movement;

        private Transform _playerTransform;

        private void Start()
        {
            _playerTransform = FindObjectOfType<PlayerHp>().transform;
        }

        public override void Activate()
        {
            base.Activate();

            SetTarget(_playerTransform);
        }

        public override void Deactivate()
        {
            base.Deactivate();

            SetTarget(null);
        }

        private void SetTarget(Transform target)
        {
            _movement.SetTarget(target);
        }
    }
}