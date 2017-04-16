namespace Drawing
{
    public class Brush
    {
        private readonly string brushColor;

        public Brush(string brushColor)
        {
            this.brushColor = brushColor;
        }

        public override string ToString()
        {
            return $"{brushColor} paintbrush";
        }
    }
}
