using UnityEngine;

namespace Movement
{
    internal class CharacterMovement : MonoBehaviour
    {
        [SerializeField] private float _speed;
        
        internal void Move(Vector3 direction)
        {
            transform.Translate(_speed * Time.deltaTime * direction);
        }
    }
}
