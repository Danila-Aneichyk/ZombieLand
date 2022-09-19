using UnityEngine;

namespace ZombieLand.Game.Enemy.Behaviour
{
    public abstract class EnemyBackToIdle : EnemyBehaviour
    {
        #region Variables

        [SerializeField] protected EnemyIdle _idle;

        #endregion


        #region Unity lifecycle

        private void OnEnable()
        {
            _idle.Activate();  
        }

        #endregion
    }
}