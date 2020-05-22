using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction
{
    public class MailService
    {
        public void SendEmail()
        {
            Connect();
            Authenticate();
            // Send Email
            Disconnect();
        }

        private void Connect()
        {
            Console.WriteLine("Connect");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnect");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticate");
        }
    }
}