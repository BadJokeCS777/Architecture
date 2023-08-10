using UnityEngine;

namespace Movement
{
    internal class MovementTest : MonoBehaviour
    {
        [SerializeField] private MovementInput _movementInput;

        private void Awake()
        {
            _movementInput.Activate();
        }
    }
}