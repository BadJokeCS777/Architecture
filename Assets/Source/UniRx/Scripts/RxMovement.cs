using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class RxMovement : MonoBehaviour
{
    private const string Vertical = "Vertical";
    private const string Horizontal = "Horizontal";
    
    [SerializeField] private float _speed = 5f;

    private Vector3 _direction;
    
    private void Start()
    {
        this.UpdateAsObservable()
            .Where(_ =>
            {
                _direction = new Vector3(Input.GetAxisRaw(Horizontal), 0f, Input.GetAxisRaw(Vertical));
                return _direction.sqrMagnitude > 0f;
            })
            .Subscribe(Move)
            .AddTo(this);
    }

    private void Move(Unit _)
    {
        transform.Translate(_speed * Time.deltaTime * _direction);
    }
}