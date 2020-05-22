using OOP.Polymorphism;

namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            DrawUIControl(new TextBox());
            DrawUIControl(new CheckBox());
        }

        public static void DrawUIControl(UIControl control)
        {
            control.Draw();
        }
    }
}