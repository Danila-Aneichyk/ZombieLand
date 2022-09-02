using System;
using UnityEngine;

namespace ZombieLand.Game.Player
{
    public class PlayerHp : MonoBehaviour
    {
        #region Variables

        [SerializeField] private int _startHp;

        [SerializeField] private int _maxHp;

        #endregion


        #region Events

        public event Action<int> OnChanged;

        #endregion


        #region Properties

        public int CurrentHp { get; private set; }

        public int MaxHp => _maxHp;

        #endregion


        #region Unity lifecycle

        private void Awake()
        {
            CurrentHp = _startHp;
            OnChanged?.Invoke(CurrentHp);
        }

        #endregion


        #region Public methods

        public void ApplyDamage(int damage)
        {
            CurrentHp = Mathf.Max(0, CurrentHp - damage);
            OnChanged?.Invoke(CurrentHp);
        }

        public void ApplyHeal(int heal)
        {
            CurrentHp = Mathf.Min(_maxHp, CurrentHp - heal);
            OnChanged?.Invoke(CurrentHp);
        }

        #endregion
    }
}