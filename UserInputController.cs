using System;

namespace DungeonGame
{
    public interface IUserInputController
    {
        UserPosition HandleInput(ConsoleKeyInfo keyInfo, UserPosition userPosition);
    }
    public class UserInputController
    {
        public UserPosition HandleInput(ConsoleKeyInfo keyInfo, UserPosition userPosition, Tile[,] map)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    var moveUpAttempt = map[(userPosition.YPosition - 1), userPosition.XPosition];
                    if(moveUpAttempt.IsWalkable)
                        userPosition.YPosition--;
                    break;

                case ConsoleKey.DownArrow:
                    var moveDownAttempt = map[(userPosition.YPosition + 1), userPosition.XPosition];
                    if(moveDownAttempt.IsWalkable)
                        userPosition.YPosition++;                    
                    break;

                case ConsoleKey.LeftArrow:
                    var moveLeftAttempt = map[userPosition.YPosition, (userPosition.XPosition - 1)];
                    if(moveLeftAttempt.IsWalkable)
                        userPosition.XPosition--;                 
                    break;

                case ConsoleKey.RightArrow:
                    var moveRightAttempt = map[userPosition.YPosition, (userPosition.XPosition + 1)];
                    if(moveRightAttempt.IsWalkable)
                        userPosition.XPosition++;                   
                    break;
            }

            return userPosition;
        }
    }
}
