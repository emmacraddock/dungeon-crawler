using System;
using System.Threading;

namespace DungeonGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Dependencies:
            var inputController = new UserInputController();
            var mapGenerator = new MapGenerator();

            Console.CursorVisible = false;

            var map = mapGenerator.CreateMap(8, 10, 4);
            mapGenerator.DrawMap(map.MapArray);

            var startPositon = map.Rooms[0].GetCenter();
            var userPosition = new UserPosition(startPositon[0], startPositon[1]);

            Console.SetCursorPosition(userPosition.XPosition, userPosition.YPosition);
            Console.WriteLine("@");

            while (true)
            {

                var input = Console.ReadKey();

                if (input.Key == ConsoleKey.Escape)
                    break;

                userPosition = inputController.HandleInput(input, userPosition, map.MapArray);

                mapGenerator.DrawMap(map.MapArray);

                Console.SetCursorPosition(userPosition.XPosition, userPosition.YPosition);

                Console.WriteLine("@");
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape) { }

        }
    }
}