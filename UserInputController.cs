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
                    if(userPosition.YPosition - 1 > -1)
                        userPosition.YPosition--;
                    break;

                case ConsoleKey.DownArrow:
                    if (userPosition.YPosition + 1 < 50)
                        userPosition.YPosition++;
                    break;

                case ConsoleKey.LeftArrow:
                    if (userPosition.XPosition - 1 > -1)
                        userPosition.XPosition--;
                    break;

                case ConsoleKey.RightArrow:
                    if (userPosition.XPosition + 1 < 50)
                        userPosition.XPosition++;
                    break;
            }

            return userPosition;
        }
    }
}
