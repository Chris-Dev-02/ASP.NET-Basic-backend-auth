using BasicBackendAuthentication.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BasicBackendAuthentication.Services
{
    public class UserService : IUserService
    {
        List<User> users = new List<User>()
        {
            new User() { Email = "duck@gmail.com", Password = "123456" },
            new User() { Email = "ultraduck@gmail.com", Password = "123456"}
        };

        public bool IsUser(string email, string password) =>
            users.Where(d => d.Email == email && d.Password == password).Count() > 0;
    }
}
