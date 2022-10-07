using UnityEngine;
using ZombieLand.Game.Enemy.Attack;
using ZombieLand.Game.Enemy.Hp;

namespace ZombieLand.Game.Boss
{
    public class BossRageBehavior : EnemyAttack
    {
        #region Variables

        private EnemyHp _bossHp;
        private EnemyMeleeAttack _bossAttack;
        private bool _isInRage;     

        #endregion

        #region Unity lifecycle

        private void Awake()
        {
            _bossHp = GetComponent<EnemyHp>();
            _bossAttack = GetComponent<EnemyMeleeAttack>();
            _bossHp.OnChanged += HpChanged; 
        }

        public override void Activate()
        {
            base.Activate();
            
            RageMode();
            _bossAttack.Activate();
        }

        public override void Deactivate()
        {
            base.Deactivate();
            
            _bossAttack.Deactivate();
        }

        #endregion


        #region Private methods

        private void HpChanged(int hp)
        {
            if (IsActive)
            {
                RageMode();
            }
        }

        private void RageMode()
        {
            if (!_isInRage && _bossHp.CurrentHp < 20)
            {
                EnterRageMode();
            }
        }

        private void EnterRageMode()
        {
            Debug.Log($"Current hp of boss is: {_bossHp.CurrentHp}");
            _bossAttack._damage += 25;
            Debug.Log($"Current damage of boss is: {_bossAttack._damage}");
        }

        #endregion
    }
}
