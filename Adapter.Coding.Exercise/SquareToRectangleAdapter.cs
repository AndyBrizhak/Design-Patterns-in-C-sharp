namespace Adapter.Coding.Exercise
{
    public class SquareToRectangleAdapter : IRectangle
    {
        public SquareToRectangleAdapter(Square square)
        {
            Width = square.Side;
            Height = square.Side;
        }

        public SquareToRectangleAdapter(int width, int height)
        {
            
        }

        public int Width { get; }
        public int Height { get; }
    }
}