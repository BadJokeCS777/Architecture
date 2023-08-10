using UnityEngine;

namespace Shooting
{
    internal class Weapon : MonoBehaviour
    {
        [SerializeField] private Bullet _bulletPrefab;
        [SerializeField] private Transform _shootPoint;
        
        internal void Shoot()
        {
            Instantiate(_bulletPrefab, _shootPoint.position, _shootPoint.rotation);
        }
    }
}
