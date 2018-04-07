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
        public const int MAP_WIDTH = 100;
        public const int MAP_HEIGHT = 25;

        public void DrawMap()
        {
            var xOffset = 6;
            var yPosition = 1;
            string[,] map = new string[MAP_HEIGHT, MAP_WIDTH];

            Console.SetCursorPosition(xOffset, yPosition);

            for (int i = 0; i < map.GetLength(0); i++)
            {
                Console.SetCursorPosition(xOffset, yPosition++);

                for (int j = 0; j < map.GetLength(1); j++)
                {
                    string s = map[i, j];
                    Console.Write("#");
                }
            }
        }

        public Room[] placeRooms(int maxRooms, int maxSize, int minSize)
        {
            var rooms = new List<Room> { };

            for(int r = 0; r < maxRooms;)
            {
                var randomNum = new Random();
                var width = minSize + randomNum.Next(maxSize - minSize + 1);
                var height = minSize + randomNum.Next(maxSize - minSize + 1);
                var x = randomNum.Next(MAP_WIDTH - width - 1) + 1;
                var y = randomNum.Next(MAP_HEIGHT - height - 1) + 1;

                var newRoom = new Room(x, y, width, height);

                var failed = false;
                foreach(var otherRoom in rooms)
                {
                    if (newRoom.IntersectsRoom(otherRoom))
                    {
                        failed = true;
                        break;
                    }
                }

                if (!failed)
                {
                    //create room

                    //push newRoom into array
                    rooms.Add(newRoom);
                    r++;
                }
            }

            return rooms.ToArray();
        }

    }
}
