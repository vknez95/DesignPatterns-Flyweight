using System;
using Drawing;

namespace DomainModel
{
    public class CeramicTile : ITile
    {
        public static int ObjectCounter = 0;

        private readonly Brush paintBrush;

        public CeramicTile()
        {
            paintBrush = Brushes.Red;
            ++ObjectCounter;
            Console.WriteLine($"Number of ceramic tile objects created is {ObjectCounter}");
        }

        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            g.FillRectangle(paintBrush, x, y, width, height);
        }
    }
}
