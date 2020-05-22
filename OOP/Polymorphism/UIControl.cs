using System;

namespace OOP.Polymorphism
{
    public abstract class UIControl
    {
        public void Enable()
        {
            Console.WriteLine("Enabled");
        }

        public abstract void Draw();
    }
}