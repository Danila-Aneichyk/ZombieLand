using UnityEngine;

namespace ZombieLand.Game.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        #region Variables
        
        [SerializeField] private PlayerAnimation _playerAnimation;

        [SerializeField] private float _speed = 4f;
        private Transform _cachedTransform;
        private Camera _mainCamera;

        #endregion


        #region Unity lifecycle

        private void Awake()
        {
            _cachedTransform = transform;
            _mainCamera = Camera.main; 
        }

        private void Update()
        {
            Move();
            Rotate();
        }


        #region Private methods

        private void Move()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector2 direction = new Vector2(horizontal, vertical);
            Vector3 moveDelta = direction * (_speed * Time.deltaTime);
            _cachedTransform.position += moveDelta;
            
            _playerAnimation.SetSpeed(direction.magnitude);
        }

        private void Rotate()
        {
            Vector3 mousePosition = Input.mousePosition;
            Vector3 worldPoint = _mainCamera.ScreenToWorldPoint(mousePosition);
            worldPoint.z = 0f;

            Vector3 direction = worldPoint - transform.position;
            _cachedTransform.up = direction;
        }

        #endregion

        #endregion
    }
}