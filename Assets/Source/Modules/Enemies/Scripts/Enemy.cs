using UnityEngine;

namespace Enemies
{
    public abstract class Enemy : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _reachDistance;

        private Transform _player;
        private IEnemyMovement _enemyMovement;

        public void Init(Transform player)
        {
            _enemyMovement = InstantiateMovement(_speed, _reachDistance, player);
        }

        protected abstract IEnemyMovement InstantiateMovement(float speed, float reachDistance, Transform player);

        private void Update()
        {
            if (_enemyMovement.TargetReached)
                return;
            
            _enemyMovement.Move(Time.deltaTime);
        }
    }
}
