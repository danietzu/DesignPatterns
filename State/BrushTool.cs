using System;

namespace State
{
    public class BrushTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Display Brush Icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}