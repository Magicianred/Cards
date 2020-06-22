using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Model
{
    public class User
    { 
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public User(string username, string password)
        {
            UserName = username;
            Password = password;
        }
             
    }
}
