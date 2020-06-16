namespace Facade
{
    internal class Program
    {
        private static void Main()
        {
            var service = new NotificationService();
            service.Send("message", "target");
        }
    }
}