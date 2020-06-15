using System;

namespace Decorator
{
    public class CloudStream : IStream
    {
        public void Write(string data)
        {
            Console.WriteLine("Storing " + data);
        }
    }
}