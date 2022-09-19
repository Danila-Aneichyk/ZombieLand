namespace ZombieLand.Game.Enemy.Behaviour
{
    public class EnemyInstanceBackToIdle : EnemyBackToIdle
    {
        #region Unity lifecycle

        private void OnEnable()
        {
            _idle.enabled = true;
        }

        #endregion
    }
}