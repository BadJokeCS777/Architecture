using UnityEngine;

namespace Movement
{
    public class MovementInput : MonoBehaviour
    {
        private const string Vertical = "Vertical";
        private const string Horizontal = "Horizontal";
        
        [SerializeField] private CharacterMovement _movement;

        private bool _active;

        private void Update()
        {
            if (_active == false)
                return;
            
            Vector3 direction = new Vector3(Input.GetAxisRaw(Horizontal), 0f, Input.GetAxisRaw(Vertical));
            
            _movement.Move(direction);
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