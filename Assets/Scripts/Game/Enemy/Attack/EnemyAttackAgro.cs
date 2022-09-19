using UnityEngine;
using ZombieLand.Game.Enemy.Follow;
using ZombieLand.Game.Enemy.Patrol;

namespace ZombieLand.Game.Enemy.Attack
{
    public class EnemyAttackAgro : MonoBehaviour
    {
        #region Variables

        [SerializeField] private TriggerObserver _triggerObserver;
        [SerializeField] private EnemyAttack _attack;
        [SerializeField] private EnemyFollow _enemyFollow;

        #endregion


        #region Unity lifecycle

        private void Start()
        {
            _triggerObserver.OnEntered += OnEntered;
            _triggerObserver.OnExited += OnExited;
        }

        #endregion


        #region Private methods

        private void OnEntered(Collider2D col)
        {
            _enemyFollow.Deactivate();
            _attack.Activate();
        }

        private void OnExited(Collider2D col)
        {
            _attack.Deactivate();
            _enemyFollow.Activate();
        }

        #endregion
    }
}