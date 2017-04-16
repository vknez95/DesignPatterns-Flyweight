using System;
using Drawing;

namespace DomainModel
{
    public class StoneTile : ITile
    {
        public static int ObjectCounter = 0;

        private readonly Brush paintBrush;

        public StoneTile()
        {
            paintBrush = Brushes.Blue;
            ++ObjectCounter;
            Console.WriteLine($"Number of stone tile objects created is {ObjectCounter}");
        }

        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            g.FillRectangle(paintBrush, x, y, width, height);
        }
    }
}
