using ApiAuth.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiAuth.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new() { Id = 1, UserName = "batman", Password = "batman", Role = "manager" },
                new() { Id = 2, UserName = "alfredo", Password = "alfredo", Role = "employee" }
            };

            users.Add(new User { Id = 2, UserName = "robin", Password = "robin", Role = "employee" });

            return users.FirstOrDefault(x => 
                            x.UserName == username && 
                            x.Password == password);
        }
    }
}
