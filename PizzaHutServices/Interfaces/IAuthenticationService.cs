using PizzaHutEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaHutServices.Interfaces
{
    public interface IAuthenticationService
    {
        public interface IAuthenticationService
        {
            public bool CreateUser(User user, string Password);
            public Task<bool> SignOut();
            public User AuthenticateUser(string Username, string Password);
            public User GetUser(string Username);
        }
    }
}
