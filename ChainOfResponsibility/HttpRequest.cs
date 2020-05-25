using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class HttpRequest
    {
        private readonly string _username;
        private readonly string _password;

        public HttpRequest(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string Username { get => _username; }
        public string Password { get => _password; }
    }
}