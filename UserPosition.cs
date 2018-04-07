using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public class UserPosition
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }

        public UserPosition(int xPostion, int yPosition)
        {
            XPosition = xPostion;
            YPosition = yPosition;
        }
    }
}
