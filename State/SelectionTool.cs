using System;

namespace State
{
    public class SelectionTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Display Selection Icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
}