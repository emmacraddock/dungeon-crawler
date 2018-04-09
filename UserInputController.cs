using System;

namespace DungeonGame
{
    public interface IUserInputController
    {
        UserPosition HandleInput(ConsoleKeyInfo keyInfo, UserPosition userPosition);
    }
    public class UserInputController
    {
        public UserPosition HandleInput(ConsoleKeyInfo keyInfo, UserPosition userPosition)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    //Console.SetCursorPosition(userPosition.XPosition, userPosition.YPosition - 1);
                    //var proposedMoveUp = Convert.ToChar(Console.Read());

                   // if (proposedMoveUp == 0x002e)
                    //{
                        Console.SetCursorPosition(userPosition.XPosition, userPosition.YPosition);
                        Console.Write(".");
                        userPosition.YPosition--;
                    //}
                    break;

                case ConsoleKey.DownArrow:

                        Console.SetCursorPosition(userPosition.XPosition, userPosition.YPosition);
                        Console.Write(".");
                        userPosition.YPosition++;
                    
                    break;

                case ConsoleKey.LeftArrow:

                        Console.SetCursorPosition(userPosition.XPosition, userPosition.YPosition);
                        Console.Write(".");
                        userPosition.XPosition--;
                    
                    break;

                case ConsoleKey.RightArrow:

                        Console.SetCursorPosition(userPosition.XPosition, userPosition.YPosition);
                        Console.Write(".");
                        userPosition.XPosition++;
                    
                    break;
            }

            return userPosition;
        }
    }
}
