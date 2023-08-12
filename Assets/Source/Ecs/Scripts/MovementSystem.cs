using Leopotam.EcsLite;
using UnityEngine;

public class MovementSystem : IEcsInitSystem, IEcsRunSystem
{
    private EcsFilter _filter;
    private EcsPool<MovementDirectionComponent> _directionPool;
    private EcsPool<MovementComponent> _movementPool;

    public void Init(IEcsSystems systems)
    {
        EcsWorld world = systems.GetWorld();
        
        _filter = world
            .Filter<MovementDirectionComponent>()
            .Inc<MovementComponent>()
            .End();
        
        _directionPool = world.GetPool<MovementDirectionComponent>();
        _movementPool = world.GetPool<MovementComponent>();
    }

    public void Run(IEcsSystems systems)
    {
        foreach (int entity in _filter)
        {
            ref MovementDirectionComponent direction = ref _directionPool.Get(entity);
            ref MovementComponent movement = ref _movementPool.Get(entity);

            Vector3 offset = movement.Speed * Time.deltaTime * direction.Value;
            movement.Transform.Translate(offset);
        }
    }
}