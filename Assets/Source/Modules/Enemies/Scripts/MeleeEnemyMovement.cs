using UnityEngine;

namespace Enemies
{
    public class MeleeEnemyMovement : IEnemyMovement
    {
        private readonly float _reachDistance;
        private readonly float _speed;
        private readonly Transform _target;
        private readonly Transform _self;

        public MeleeEnemyMovement(float speed, float reachDistance, Transform target, Transform self)
        {
            _speed = speed;
            _reachDistance = reachDistance;
            _target = target;
            _self = self;
        }

        public bool TargetReached => Vector3.Distance(_target.position, _self.position) <= _reachDistance;
        
        public void Move(float deltaTime)
        {
            Vector3 direction = (_target.position - _self.position).normalized;
            
            _self.Translate(_speed * deltaTime * direction);
        }
    }
}