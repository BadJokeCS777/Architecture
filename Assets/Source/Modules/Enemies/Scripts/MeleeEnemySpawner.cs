using UnityEngine;

namespace Enemies
{
    internal class MeleeEnemySpawner : EnemySpawner
    {
        [SerializeField] private Enemy _enemy;
        [SerializeField] private Transform _spawnPoint;
        
        protected override Enemy Spawn()
        {
            return Instantiate(_enemy, _spawnPoint.position, _spawnPoint.rotation);
        }
    }
}