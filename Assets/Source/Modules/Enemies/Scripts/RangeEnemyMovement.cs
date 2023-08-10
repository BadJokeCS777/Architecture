using UnityEngine;

namespace Enemies
{
    public class RangeEnemyMovement : IEnemyMovement
    {
        private readonly float _reachDistance;
        private readonly float _waitDuration;
        private readonly Transform _target;
        private readonly Transform _self;

        private float _timer;
        
        public RangeEnemyMovement(float reachDistance, float waitDuration, Transform target, Transform self)
        {
            _reachDistance = reachDistance;
            _waitDuration = waitDuration;
            _target = target;
            _self = self;
        }

        public bool TargetReached => Vector3.Distance(_target.position, _self.position) <= _reachDistance;
        
        public void Move(float deltaTime)
        {
            if (_timer >= _waitDuration)
            {
                _timer -= _waitDuration;

                Vector3 way = _target.position - _self.position;
                Vector3 direction = way.normalized;
                float distance = way.magnitude;
                Vector3 newPosition = _self.position + (direction * distance);
                
                _self.position = newPosition;
            }
            else
            {
                _timer += deltaTime;
            }
        }
    }
}