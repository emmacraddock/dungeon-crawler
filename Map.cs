namespace DungeonGame
{
    public class Map
    {
        public Map(Tile[,] mapArray, Room[] rooms)
        {
            MapArray = mapArray;
            Rooms = rooms; 
        }

        public Tile[,] MapArray { get; set; }
        public Room[] Rooms { get; set; }
    }
}
