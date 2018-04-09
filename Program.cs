using System;

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

            mapGenerator.CreateMap();
            mapGenerator.PlaceRooms(1, 10, 2);
            mapGenerator.DrawMap();

            //var startPositon = map[0].GetCenter();
            //var userPosition = new UserPosition((int)startPositon[0], (int)startPositon[1]);

            //Console.SetCursorPosition(userPosition.XPosition, userPosition.YPosition);
            //Console.WriteLine("@");

            //while (true)
            //{

            //    var input = Console.ReadKey();

            //    if (input.Key == ConsoleKey.Escape)
            //        break;

            //    userPosition = inputController.HandleInput(input, userPosition);

            //    Console.SetCursorPosition(userPosition.XPosition, userPosition.YPosition);
                
            //    Console.WriteLine("@");
            //}

            while (Console.ReadKey().Key != ConsoleKey.Escape) { }

        }
    }
}