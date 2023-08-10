using UnityEngine;

namespace Enemies
{
    internal class RangeEnemySpawner : EnemySpawner
    {
        [SerializeField] private Enemy _enemy;
        [SerializeField] private Transform[] _spawnPoints;

        private int _spawnPointIndex = 0;
        
        protected override Enemy Spawn()
        {
            Transform spawnPoint = _spawnPoints[_spawnPointIndex];
            _spawnPointIndex++;

            if (_spawnPointIndex >= _spawnPoints.Length)
                _spawnPointIndex = 0;
            
            return Instantiate(_enemy, spawnPoint.position, spawnPoint.rotation);
        }
    }
}