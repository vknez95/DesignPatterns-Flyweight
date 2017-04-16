using System;
using Drawing;

namespace DomainModel
{
    public class QuarryTile : ITile
    {
        public static int ObjectCounter = 0;

        private readonly Brush paintBrush;

        public QuarryTile()
        {
            paintBrush = Brushes.White;
            ++ObjectCounter;
            Console.WriteLine($"Number of quarry tile objects created is {ObjectCounter}");
        }

        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            g.FillRectangle(paintBrush, x, y, width, height);
        }
    }
}