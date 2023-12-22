using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ooj
{
    public struct User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User (string username, string password)
        {
            Username = username;
            Password = password;
        }

    }

    
}
