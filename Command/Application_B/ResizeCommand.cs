using Command.Framework;
using System;

namespace Command.Application_B
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Resize image");
        }
    }
}