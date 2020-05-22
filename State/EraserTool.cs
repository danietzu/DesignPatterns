using System;

namespace State
{
    public class EraserTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Display Eraser Icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Erase selection");
        }
    }
}