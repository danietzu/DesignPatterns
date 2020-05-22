using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class User
    {
        // Fields
        public string Name;

        public User(string name)
        {
            Name = name;
        }

        // Methods
        public void SayHello()
        {
            Console.WriteLine("Hi, my name is " + Name);
        }
    }
}