using System.Collections;
using UnityEngine;

namespace Enemies
{
    public abstract class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private float _spawnInterval = 3f;

        private Coroutine _spawning;
        
        public void StartSpawn()
        {
            _spawning = StartCoroutine(Spawning());
        }

        public void StopSpawn()
        {
            if (_spawning != null)
                StopCoroutine(_spawning);
        }
        
        protected abstract Enemy Spawn();

        private IEnumerator Spawning()
        {
            while (true)
            {
                yield return new WaitForSeconds(_spawnInterval);
                
                Spawn();
            }
        }
    }
}
