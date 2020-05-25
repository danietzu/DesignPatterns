using System;

namespace ChainOfResponsibility
{
    internal class Program
    {
        private static void Main()
        {
            // pipeline:
            // authenticator -> logger -> compressor
            var compressor = new Compressor(null); // being the last one it is referenced
            var logger = new Logger(compressor);
            var authenticator = new Authenticator(logger);

            var server = new WebServer(authenticator); // passing just the first handler
            server.Handle(new HttpRequest("admin", "1234"));
        }
    }
}