using Enemies;
using UnityEngine;
using Movement;
using Shooting;

public class GameRoot : MonoBehaviour
{
    [SerializeField] private MovementInput _movementInput;
    [SerializeField] private WeaponInput _weaponInput;
    [SerializeField] private EnemySpawner _enemySpawner;
    [SerializeField] private EnemySpawner[] _enemySpawners;
    
    private void Start()
    {
        //_movementInput.Init();
        //_weaponInput.Init(_movementInput.State);
        _movementInput.Activate();
        _weaponInput.Activate();
        _enemySpawner.StartSpawn();

        foreach (EnemySpawner spawner in _enemySpawners)
            spawner.StartSpawn();
        
        //var wallJump = new WallJump(_movementInput);
    }
}
