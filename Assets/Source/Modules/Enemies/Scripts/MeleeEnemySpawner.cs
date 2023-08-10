using UnityEngine;
using Zenject;

namespace Enemies
{
    internal class MeleeEnemySpawner : EnemySpawner
    {
        [SerializeField] private Transform _player;
        [SerializeField] private Enemy _enemy;
        [SerializeField] private Transform _spawnPoint;
        
        [Inject]
        public void Construct(Transform player)
        {
            _player = player;
        }
        
        protected override Enemy Spawn()
        {
            Enemy enemy = Instantiate(_enemy, _spawnPoint.position, _spawnPoint.rotation);
            enemy.Init(_player);
            return enemy;
        }
    }
}