using Leopotam.EcsLite;
using UnityEngine;

public class PlayerInputSystem : IEcsInitSystem, IEcsRunSystem
{
    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";
    
    private EcsFilter _filter;
    private EcsPool<MovementDirectionComponent> _directionPool;

    public void Init(IEcsSystems systems)
    {
        EcsWorld world = systems.GetWorld();
        
        _filter = world
            .Filter<MovementDirectionComponent>()
            .End();

        _directionPool = world.GetPool<MovementDirectionComponent>();
    }
    
    public void Run(IEcsSystems systems)
    {
        Vector3 rawDirection = new(Input.GetAxisRaw(HorizontalAxis), 0f, Input.GetAxisRaw(VerticalAxis));
        
        foreach (int entity in _filter)
        {
            ref MovementDirectionComponent direction = ref _directionPool.Get(entity);
            direction.Value = rawDirection;
        }
    }
}