using Leopotam.EcsLite;
using UnityEngine;

public class EcsStart : MonoBehaviour
{
    [SerializeField] private float _playerSpeed;
    [SerializeField] private Transform _playerTransform;

    private EcsWorld _world;
    private EcsSystems _systems;
    
    private void Start()
    {
        _world = new EcsWorld();
        _systems = new EcsSystems(_world);
        
        AddPlayerEntity();
        
        _systems
            .Add(new PlayerInputSystem())
            .Add(new MovementSystem())
            .Init();
    }

    private void Update()
    {
        _systems.Run();
    }

    private void AddPlayerEntity()
    {
        int player = _world.NewEntity();

        EcsPool<MovementComponent> movementPool = _world.GetPool<MovementComponent>();
        
        ref MovementComponent movement = ref movementPool.Add(player);
        movement.Speed = _playerSpeed;
        movement.Transform = _playerTransform;

        _world
            .GetPool<MovementDirectionComponent>()
            .Add(player);
    }
}