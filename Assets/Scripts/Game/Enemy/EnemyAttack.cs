using UnityEngine;

namespace ZombieLand.Game.Enemy
{
    public class EnemyAttack : MonoBehaviour
    {
        #region Variables

        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private Transform _bulletSpawnPositionTransform;
        [SerializeField] private float _fireDelay = 0.3f;
        [SerializeField] private Transform _player;

        private Transform _cachedTransform;
        private float _timer;

        #endregion


        #region Unity lifecycle

        private void Update()
        {
            TickTimer();
            Attack();
        }

        #endregion


        #region Private methods

        private void Attack()
        {
           //  Instantiate(_bulletPrefab, _player.position, _cachedTransform.rotation);
            _timer = _fireDelay;
        }

        private void TickTimer()
        {
            _timer -= Time.deltaTime;
        }

        #endregion
    }
}