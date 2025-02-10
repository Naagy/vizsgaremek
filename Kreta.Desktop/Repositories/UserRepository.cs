using Real.Shared.Models;
using System;
using System.Net;

namespace Real.Desktop.Repositories
{
    public class UserRepository
    {
        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool validUser = true;
            return validUser;
        }

        public User? GetByUsername(string userName)
        {
             return new User
             {
                 Username = "teszt",
                 Email = "teszt@teszt.hu",
                 FirstName = "Elek",
                 LastName = "Teszt",
                 Password = "test@123"
             };
        }
    }
}
