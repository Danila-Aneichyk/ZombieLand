using UnityEngine;
using ZombieLand.Game.Enemy.Attack;
using ZombieLand.Game.Enemy.Behaviour;
using ZombieLand.Game.Enemy.Follow;

namespace ZombieLand.Game.Enemy
{
    [RequireComponent(typeof(EnemyFollowAgro))]
    [RequireComponent(typeof(EnemyAttackAgro))]
    public class EnemyStarter : MonoBehaviour
    {
        [SerializeField] private EnemyIdle _idle;

        private void Start()
        {
            _idle.Activate();
        }
    }
}