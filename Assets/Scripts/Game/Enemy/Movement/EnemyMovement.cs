using UnityEngine;

namespace ZombieLand.Game.Enemy.Movement
{
    public abstract class EnemyMovement : MonoBehaviour
    {
        public abstract void SetTarget(Transform target);
    }
}