using UnityEngine;

namespace Enemies
{
    internal class RangeEnemy : Enemy
    {
        [SerializeField] private float _waitDuration;
        
        protected override IEnemyMovement InstantiateMovement(float speed, float reachDistance, Transform player)
        {
            return new RangeEnemyMovement(reachDistance, _waitDuration, player, transform);
        }
    }
}