using Auth.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Contracts
{
    public interface IUserService
    {
        User Authenticate(string userName, string password);
    }
}
