namespace SOLID.LSP.Example1
{
    public class Rectangle
    {
        // apply virtual for upcasting substitution
        public virtual int Width { get; set; }

        public virtual int Height { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }
}