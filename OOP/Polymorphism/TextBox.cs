using System;

namespace OOP.Polymorphism
{
    public class TextBox : UIControl
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Text Box");
        }
    }
}