using System;

namespace DungeonGame
{
    public interface IRoom
    {
        int X1 { get; set; }
        int X2 { get; set; }
        int Y1 { get; set; }
        int Y2 { get; set; }

        int[] GetCenter();
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

        public int[] GetCenter()
        {
            var x = Math.Floor(((double)(X1) + (double)X2) / 2);
            var y = Math.Floor(((double)Y1 + (double)Y2) / 2);
            return new int[] { (int)x, (int)y };
        }

        public bool IntersectsRoom(Room room)
        {
            return (X1 <= room.X2 && X2 >= room.X1 &&
            Y1 <= room.Y2 && Y2 >= room.Y1);
        }
    }
}
