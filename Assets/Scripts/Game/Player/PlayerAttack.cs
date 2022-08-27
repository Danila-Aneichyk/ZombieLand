using UnityEngine;

namespace ZombieLand.Game.Player
{
    public class PlayerAttack : MonoBehaviour
    {
        #region Variables

        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private Transform _bulletSpawnPositionTransform; 
        private Transform _cachedTransform; 
         

        #endregion


        #region Unity lifecycle

        private void Awake()
        {
            _cachedTransform = transform; 
        }

        private void Update()
        {
            if (CanAttack())
            {
                Attack(); 
            }
        }

        #endregion


        #region Private methods

        private void Attack()
        {
            Instantiate(_bulletPrefab,_bulletSpawnPositionTransform.position, _cachedTransform.rotation); 
        }

        private bool CanAttack()
        {
            return Input.GetButtonDown("Fire1");   
        }

        #endregion
    }
}
