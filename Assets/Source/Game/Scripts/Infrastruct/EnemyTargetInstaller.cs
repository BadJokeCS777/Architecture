using UnityEngine;
using Zenject;

namespace MyGame
{
    public class EnemyTargetInstaller : MonoInstaller
    {
        [SerializeField] private Transform _player;
        
        public override void InstallBindings()
        {
            Container
                .Bind<Transform>()
                .FromInstance(_player)
                .AsSingle();
        }
    }
}
