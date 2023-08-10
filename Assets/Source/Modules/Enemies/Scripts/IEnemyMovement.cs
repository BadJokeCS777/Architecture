namespace Enemies
{
    public interface IEnemyMovement
    {
        public bool TargetReached { get; }

        public void Move(float deltaTime);
    }
}