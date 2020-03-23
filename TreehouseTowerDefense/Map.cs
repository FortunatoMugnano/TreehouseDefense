using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseTowerDefense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            return point.X >= 0 && point.Y < Width &&
                   point.Y >= 0 && point.X < Height;

        }
    }
}
