using System;

namespace DungeonGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Dependencies:
            var inputController = new UserInputController();
            var userPosition = new UserPosition(4, 4);
            var mapGenerator = new MapGenerator();

            //Console.SetCursorPosition(userPosition.XPosition, userPosition.YPosition);
            //Console.WriteLine("X");
   
            mapGenerator.DrawMap();
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }

            //while (true)
            //{

            //    var input = Console.ReadKey();

            //    if (input.Key == ConsoleKey.Escape)
            //        break;

            //    userPosition = inputController.HandleInput(input, userPosition);

            //    Console.Clear();
            //    Console.SetCursorPosition(userPosition.XPosition, userPosition.YPosition);
            //    Console.WriteLine("X");
            //}
        }
    }
}