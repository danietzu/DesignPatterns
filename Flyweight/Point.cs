using System;

namespace Flyweight
{
    public class Point
    {
        private readonly int _x; // 4 bytes
        private readonly int _y; // 4 bytes
        private readonly PointIcon _icon;

        //private readonly PointType _type; // 4 bytes
        //private readonly byte[] _icon; // 20 KB -> 20 MB

        public Point(int x, int y, PointIcon icon)
        {
            _x = x;
            _y = y;
            _icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine($"{_icon.Type} at ({_x}, {_y})");
        }
    }
}