using System;

namespace TDS.Game.Objects
{
    public interface IHealth
    {
        event Action<int> OnChanged;

        int CurrentHp { get; }
        int MaxHp { get; }

        void ApplyDamage(int damage);
        void ApplyHeal(int heal);
    }
}