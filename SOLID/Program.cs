using SOLID.LSP.Example2;
using System;

namespace SOLID
{
    public class Program
    {
        public static void Main()
        {
            IManager peach = new CEO
            {
                FirstName = "Peach"
            };
            peach.CalculatePerHourRate(6);

            IManaged mario = new Manager
            {
                FirstName = "Mario"
            };
            mario.AssignManager(peach);
            mario.CalculatePerHourRate(4);

            Employee luigi = new Employee
            {
                FirstName = "Luigi"
            };
            luigi.AssignManager(mario);
            luigi.CalculatePerHourRate(2);

            Console.WriteLine($"{luigi.FirstName}'s salary is {luigi.Salary}/hour");
        }
    }
}