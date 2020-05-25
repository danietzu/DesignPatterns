namespace ChainOfResponsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest httpRequest)
        {
            var isValid = httpRequest.Username == "admin" &&
                          httpRequest.Password == "1234";

            System.Console.WriteLine("Authentication");

            return !isValid; // if false _next will be called
        }
    }
}