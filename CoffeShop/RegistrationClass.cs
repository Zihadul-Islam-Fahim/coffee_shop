using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    public class RegistrationClass
    {
        private string firstname;
        private string lastName;
        private string username;
        private string password;

        public string Firstname { get => firstname; set => firstname = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
