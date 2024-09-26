using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mgmtService.Database;
using mgmtService.Functionality;
using mgmtService.Model;

namespace mgmtService.Service
{
    public class UserService : IUserOperation
    {
        UserDbContext userDbContext;
        public UserService()
        {
            userDbContext = new UserDbContext();
        }
        int IUserOperation.AccountValidate(string Username, string Password)
        {
            var temp = userDbContext.users.Where(u=>u.Username == Username && u.Password == Password).FirstOrDefault();
            if (temp!=null)
            {
                return 1;
            }
            return 0;
        }

        int IUserOperation.CreateAccount(User user)
        {
            userDbContext.users.Add(user);
            return userDbContext.SaveChanges();
        }
    }
}