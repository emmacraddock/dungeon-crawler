using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public interface IMapGenerator
    {

    }
    public class MapGenerator
    {
        public const int MAP_COLUMNS = 100;
        public const int MAP_ROWS = 25;
        public Tile[,] _map =  new Tile[MAP_ROWS, MAP_COLUMNS];

        public Map CreateMap(int maxRooms, int maxSize, int minSize)
        {
            for (int row = 0; row < MAP_ROWS; row++)
            {
                for (int column = 0; column < MAP_COLUMNS; column++)
                {

                    _map[row, column] = new Tile(TileType.Empty);
                }
            }

            var rooms = new List<Room> { };
            var newCenter = new int[]{ };

            for (int r = 0; r < maxRooms;)
            {
                var randomNum = new Random();
                var width = minSize + randomNum.Next(maxSize - minSize + 1);
                var height = minSize + randomNum.Next(maxSize - minSize + 1);
                var x = randomNum.Next(MAP_COLUMNS - width - 1) + 1;
                var y = randomNum.Next(MAP_ROWS - height - 1) + 1;

                var newRoom = new Room(x, y, width, height);
                newCenter = newRoom.GetCenter();

                var failed = false;
                foreach (var otherRoom in rooms)
                {
                    if (newRoom.IntersectsRoom(otherRoom))
                    {
                        failed = true;
                        break;
                    }
                }

                if (!failed)
                {
                    if(rooms.Count != 0)
                    {
                        var prevCenter = rooms[rooms.Count - 1].GetCenter();
         
                        if(randomNum.Next(1, 2) == 1)
                        {
                            hCorridor(prevCenter[0], newCenter[0], prevCenter[1]);
                            vCorridor(prevCenter[1], newCenter[1], newCenter[0]);
                        }
                        else
                        {
                            vCorridor(prevCenter[1], newCenter[1], prevCenter[0]);
                            hCorridor(prevCenter[0], newCenter[0], newCenter[1]);
                        }
                    }

                    CreateRoom(newRoom);                    
                    rooms.Add(newRoom);
                    r++;
                }
            }

            return new Map(_map, rooms.ToArray());
        }

        public void CreateRoom(Room room)
        {
            var row = room.Y1;
            while (row <= room.Y2)
            {
                for (var x = room.X1; x <= room.X2; x++)
                {
                   // _map[row, x] = TileType.Wall;
                   // if (x > room.X1 && x < room.X2 && row > room.Y1 && row < room.Y2)
                        _map[row, x] = new Tile(TileType.Dirt, true);
                }
                row++;
            }
        }

        private void hCorridor(int x1, int x2, int y)
        {
            for (int x = Math.Min(x1, x2); x <= Math.Max(x1, x2); x++)
            {
                _map[y, x] = new Tile(TileType.Dirt, true);
            }
        }

        private void vCorridor(int y1, int y2, int x)
        {
            for (int y = Math.Min(y1, y2); y <= Math.Max(y1, y2); y++)
            {
                _map[y, x] = new Tile(TileType.Dirt, true);
            }
        }

        public void DrawMap(Tile[,] map)
        {
            for (int row = 0; row < MAP_ROWS; row++)
            {
                for (int column = 0; column < MAP_COLUMNS; column++)
                {
                    var tile = map[row, column];
                    Console.SetCursorPosition(column, row);
                    var tileChar = GetTile(tile);
                    Console.Write(tileChar);
                }
            }
        }

        private string GetTile(Tile tile)
        {
            if (tile.TileType == TileType.Dirt)
                return ".";
            if (tile.TileType == TileType.Wall)
                return "#";
            return "";
        }

    }
}
