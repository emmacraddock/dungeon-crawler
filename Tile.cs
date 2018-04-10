namespace DungeonGame
{
    public class Tile
    {
        public Tile(TileType tileType, bool isWalkable = false, bool isVisible = false)
        {
            TileType = tileType;
            IsWalkable = isWalkable;
            IsVisible = isVisible;
        }

        public TileType TileType { get; set; }
        public bool IsWalkable { get; set; }
        public bool IsVisible { get; set; }
    }
    public enum TileType
    {
        Empty = 0,
        Dirt = 1,
        Wall = 2,
    }
}
