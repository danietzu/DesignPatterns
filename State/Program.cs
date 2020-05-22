namespace State
{
    internal class Program
    {
        private static void Main()
        {
            var canvas = new Canvas
            {
                CurrentTool = new EraserTool()
            };

            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}