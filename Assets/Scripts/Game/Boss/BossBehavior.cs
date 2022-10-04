using UnityEngine;
using ZombieLand.Game.Enemy.Attack;
using ZombieLand.Game.Enemy.Hp;

namespace ZombieLand.Game.Boss
{
    public class BossBehavior : MonoBehaviour
    {
        #region Variables

        private EnemyHp _bossHp;
        private EnemyMeleeAttack _bossAttack; 

        #endregion


        #region Unity lifecycle

        private void Awake()
        {
            _bossHp = GetComponent<EnemyHp>();
            _bossAttack = GetComponent<EnemyMeleeAttack>(); 
        }

        private void Update()
        {
            RageMode();
        }

        #endregion


        #region Private methods

        private void RageMode()
        {
            if (_bossHp.CurrentHp<20)
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
