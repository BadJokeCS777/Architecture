using TMPro;
using UniRx;
using UnityEngine;

public class RxHealthBar : MonoBehaviour
{
    private readonly CompositeDisposable _disposable = new();
    
    [SerializeField] private RxHealth _health;
    [SerializeField] private TMP_Text _text;

    private void Start()
    {
        _health.Value
            .Subscribe(OnHealthChanged)
            .AddTo(_disposable);
    }

    private void OnDestroy()
    {
        _disposable.Clear();
        _disposable.Dispose();
    }

    private void OnHealthChanged(int value)
    {
        _text.text = value.ToString();
    }
}