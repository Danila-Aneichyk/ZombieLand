using UnityEngine;

namespace ZombieLand.Game.Enemy.Behaviour
{
    public class EnemyInstantBackToIdle : EnemyBackToIdle
    {
        [SerializeField] private EnemyIdle _idle;

        public override void Activate()
        {
            base.Activate();
            
            Deactivate();
            _idle.Activate();
        }
    }
}