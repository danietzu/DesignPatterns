using Command.Framework;
using System;

namespace Command.Application_B
{
    public class BlackAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Apply B&W filter");
        }
    }
}