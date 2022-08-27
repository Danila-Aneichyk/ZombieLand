using UnityEngine;

namespace ZombieLand.Game.Player
{
    public class PlayerAttack : MonoBehaviour
    {
        #region Variables

        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private Transform _bulletSpawnPositionTransform;
        [SerializeField] private float _fireDelay = 0.3f;

        private Transform _cachedTransform;
        private float _timer;

        #endregion


        #region Unity lifecycle

        private void Awake()
        {
            _cachedTransform = transform;
        }

        private void Update()
        {
            TickTimer();
            
            if (CanAttack())
            {
                Attack();
            }
        }

        #endregion


        #region Private methods

        private void Attack()
        {
            Instantiate(_bulletPrefab, _bulletSpawnPositionTransform.position, _cachedTransform.rotation);
            _timer = _fireDelay;
        }

        private bool CanAttack()
        {
            return Input.GetButton("Fire1") && _timer <= 0;
        }

        private void TickTimer()
        {
            _timer -= Time.deltaTime;
        }

        #endregion
    }
}