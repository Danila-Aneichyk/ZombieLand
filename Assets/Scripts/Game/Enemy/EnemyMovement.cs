using UnityEngine;

namespace ZombieLand.Game.Enemy
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class EnemyMovement : MonoBehaviour
    {
        #region Variables

        [SerializeField] private float _speed = 4;
        
        [SerializeField] private Transform _target;

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
        }

        #endregion


        #region Private methods

        private void MoveToTarget()
        {
            Vector3 direction = (_target.position - _cachedTransform.position).normalized;
            SetVelocity(direction * _speed);
        }

        private bool IsTargetValid()
        {
            return _target != null;
        }

        public void SetTarget(Transform target)
        {
            _target = target;
            
            if(_target == null)
                SetVelocity(Vector2.zero);
        }

        private void SetVelocity(Vector2 velocity)
        {

            _rb.velocity = velocity; 
        }

        #endregion
    }
}