using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _health;

    public event Action<int> HealthChanged;

    [ContextMenu(nameof(Heal))]
    private void Heal()
    {
        _health += 10;
        HealthChanged?.Invoke(_health);
    }

    [ContextMenu(nameof(Damage))]
    private void Damage()
    {
        _health -= 10;
        HealthChanged?.Invoke(_health);
    }
}