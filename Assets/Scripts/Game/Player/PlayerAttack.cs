using UnityEngine;
using ZombieLand.Game.Enemy;

namespace ZombieLand.Game.Player
{
    public class PlayerAttack : MonoBehaviour
    {
        #region Variables

        [SerializeField] private PlayerAnimation _playerAnimation;
        [SerializeField] private EnemyHp _enemyHp;
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
            _timer = _fireDelay;
            _playerAnimation.PlayShoot();
            Instantiate(_bulletPrefab, _bulletSpawnPositionTransform.position, _cachedTransform.rotation);
        }

        private bool CanAttack()
        {
            return Input.GetButton("Fire1") && _timer <= 0;
        }

        private void TickTimer()
        {
            _timer -= Time.deltaTime;
        }
    }

    #endregion
}