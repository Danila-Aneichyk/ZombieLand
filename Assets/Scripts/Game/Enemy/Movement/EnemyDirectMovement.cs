using UnityEngine;

namespace ZombieLand.Game.Enemy.Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class EnemyDirectMovement : EnemyMovement
    {
        #region Variables

        [SerializeField] private float _speed = 4;

        [SerializeField] private Transform _target;

        [SerializeField] private EnemyAnimation _enemyAnimation; 

        private Rigidbody2D _rb;

        private Transform _cachedTransform;

        #endregion


        #region Unity lifecycle

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _cachedTransform = transform;
        }

        private void FixedUpdate()
        {
            if (!IsTargetValid())
                return;

            MoveToTarget();
            RotateToTarget();
        }

        private void OnDisable()
        {
            SetVelocity(Vector2.zero);
        }

        #endregion


        #region Private methods

        public override void SetTarget(Transform target)
        {
            _target = target;
            Debug.Log("TargetSet");
            if (_target == null)
                SetVelocity(Vector2.zero);
        }

        #endregion


        #region Private methods

        private void RotateToTarget()
        {
            Vector3 direction = (_target.position - _cachedTransform.position);
            _cachedTransform.up = direction;
        }

        private bool IsTargetValid() =>
            _target != null;

        private void MoveToTarget()
        {
            Vector3 direction = (_target.position - _cachedTransform.position).normalized;
            SetVelocity(direction * _speed);
            _enemyAnimation.PlayWalk(direction.magnitude);
        }

        private void SetVelocity(Vector2 velocity)
        {
            _rb.velocity = velocity;
        }

        #endregion
    }
}