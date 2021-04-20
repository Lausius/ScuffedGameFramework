namespace ScuffedGameFramework
{
    public interface IWorld
    {
        Area MaxX { get; set; }
        Area MaxY { get; set; }

        void DrawSquareWorld();
        bool IsPositionWalkable(int x, int y);
    }
}