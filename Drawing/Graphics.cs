using System;

namespace Drawing
{
    public class Graphics
    {
        public void FillRectangle(Brush brush, int x, int y, int width, int height)
        {
            Console.WriteLine($"Drawing rectangle at point x-coor = {x} and y-coor = {y}; " +
                $"width = {width} and height = {height}");
            Console.WriteLine($"Filling rectangle with {brush}");
            Console.WriteLine();
        }
    }
}