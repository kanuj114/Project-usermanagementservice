using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mgmtService.Model;

namespace mgmtService.Functionality
{
    public interface IUserOperation
    {
        public int CreateAccount(User user);

        public int AccountValidate(string Username, string Password);
    }
}