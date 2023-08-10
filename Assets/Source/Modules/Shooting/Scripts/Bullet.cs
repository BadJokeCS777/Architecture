using UnityEngine;

namespace Shooting
{
    internal class Bullet : MonoBehaviour
    {
        [SerializeField] private float _speed = 5f;
        [SerializeField] private float _lifetime = 5f;

        private float _deathTimer = 0f;
        
        private void Update()
        {
            transform.Translate(_speed * Time.deltaTime * transform.forward);

            _deathTimer += Time.deltaTime;

            if (_deathTimer >= _lifetime)
                Destroy(gameObject);
        }
    }
}