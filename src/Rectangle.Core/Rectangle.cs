using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle.Core
{
    public class Rectangle
    {
        public Rectangle(int positionX, int positionY, int height, int width, char symbol)
        {
            PositionX = positionX;
            PositionY = positionY;
            Height = height;
            Width = width;
            Symbol = symbol;
        }

        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public int Height { get; private set; }
        public int Width { get; private set; }

        public char Symbol { get; private set; }

    }
}
