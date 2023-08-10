using UnityEngine;
using Zenject;

namespace Enemies
{
    internal class RangeEnemySpawner : EnemySpawner
    {
        [SerializeField] private Transform _player;
        [SerializeField] private Enemy _enemy;
        [SerializeField] private Transform[] _spawnPoints;

        private int _spawnPointIndex = 0;

        [Inject]
        public void Construct(Transform player)
        {
            _player = player;
        }
        
        protected override Enemy Spawn()
        {
            Transform spawnPoint = _spawnPoints[_spawnPointIndex];
            _spawnPointIndex++;

            if (_spawnPointIndex >= _spawnPoints.Length)
                _spawnPointIndex = 0;
            
            Enemy enemy = Instantiate(_enemy, spawnPoint.position, spawnPoint.rotation);
            enemy.Init(_player);
            return enemy;
        }
    }
}