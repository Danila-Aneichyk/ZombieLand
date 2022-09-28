using UnityEngine;
using ZombieLand.Game.Enemy.Follow;
using ZombieLand.Game.Enemy.Patrol;

namespace ZombieLand.Game.Enemy.Attack
{
    public class EnemyAttackAgro : MonoBehaviour
    {
        [SerializeField] private TriggerObserver _triggerObserver;
        [SerializeField] private EnemyAttack _attack;
        [SerializeField] private EnemyFollow _follow;

        private void Start()
        {
            _triggerObserver.OnEntered += OnEntered;
            _triggerObserver.OnExited += OnExited;
        }

        private void OnEntered(Collider2D col)
        {
            _follow.Deactivate();
            _attack.Activate();
        }

        private void OnExited(Collider2D col)
        {
            _attack.Deactivate();
            _follow.Activate();
        }
    }
}