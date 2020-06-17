namespace Flyweight
{
    internal class Program
    {
        private static void Main()
        {
            var service = new PointService(new PointIconFactory());
            foreach (var point in service.GetPoints())
            {
                point.Draw();
            }
        }
    }
}