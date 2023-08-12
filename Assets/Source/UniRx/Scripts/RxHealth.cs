using UniRx;
using UnityEngine;

public class RxHealth : MonoBehaviour
{
    public ReactiveProperty<int> Value;

    [ContextMenu(nameof(Heal))]
    private void Heal()
    {
        Value.Value += 10;
    }

    [ContextMenu(nameof(Damage))]
    private void Damage()
    {
        Value.Value -= 10;
    }
}