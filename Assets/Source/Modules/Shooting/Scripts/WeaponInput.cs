using UnityEngine;

namespace Shooting
{
    public class WeaponInput : MonoBehaviour
    {
        private const string Fire = "Fire1";
        
        [SerializeField] private Weapon _weapon;

        private bool _active;

        private void Update()
        {
            if (_active == false)
                return;

            if (Input.GetAxisRaw(Fire) > 0f)
                _weapon.Shoot();
        }

        public void Activate()
        {
            _active = true;
        }

        public void Deactivate()
        {
            _active = false;
        }
    }
}