using System;

namespace Iterator
{
    internal class Program
    {
        private static void Main()
        {
            var history = new BrowseHistory<string>();
            var iterator = history.CreateIterator();

            history.Push("a");
            history.Push("b");
            history.Push("c");
            history.Pop();
            history.Push("d");

            while (iterator.HasNext())
            {
                var url = iterator.Current();
                Console.WriteLine(url);

                iterator.Next();
            }
        }
    }
}