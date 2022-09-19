using UnityEngine;
using ZombieLand.Game.Enemy.Behaviour;
using ZombieLand.Game.Enemy.Patrol;

namespace ZombieLand.Game.Enemy.Follow
{
    public class EnemyFollowAgro : EnemyFollow 
    {
        #region Variables

        [SerializeField] private EnemyFollow _enemyFollow;
        [SerializeField] private EnemyBackToIdle _backToIdle;
        [SerializeField] private TriggerObserver _triggerObserver;

        #endregion


        #region Unity lifecycle

        private void Start()
        {
            _triggerObserver.OnEntered += OnEntered;
            _triggerObserver.OnExited += OnExited;
        }

        private void OnEntered(Collider2D col)
        {
            _backToIdle.Deactivate();
            _enemyFollow.Activate();
        } 

        private void OnExited(Collider2D other)
        {
            _enemyFollow.Deactivate();
            _backToIdle.Activate(); 
        }

        #endregion
    }
}