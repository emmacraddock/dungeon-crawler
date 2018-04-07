using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonGame
{
    public interface IRoom
    {
        int X1 { get; set; }
        int X2 { get; set; }
        int Y1 { get; set; }
        int Y2 { get; set; }

        bool IntersectsRoom(Room room);
    }
    public class Room : IRoom
    {
        public Room(int x, int y, int w, int h)
        {
            X1 = x;
            X2 = x + w;
            Y1 = y;
            Y2 = y + h;
        } 

        // grid coordinates for each corner
        public int X1 { get; set; }
        public int X2 { get; set; }
        public int Y1 { get; set; }
        public int Y2 { get; set; }

        public bool IntersectsRoom(Room room)
        {
            return (X1 <= room.X2 && X2 >= room.X1 &&
            Y1 <= room.Y2 && room.Y2 >= room.Y1);
        }
    }
}
