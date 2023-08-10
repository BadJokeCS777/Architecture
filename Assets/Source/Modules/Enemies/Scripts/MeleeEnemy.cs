using UnityEngine;

namespace Enemies
{
    internal class MeleeEnemy : Enemy
    {
        protected override IEnemyMovement InstantiateMovement(float speed, float reachDistance, Transform player)
        {
            return new MeleeEnemyMovement(speed, reachDistance, player, transform);
        }
    }
}