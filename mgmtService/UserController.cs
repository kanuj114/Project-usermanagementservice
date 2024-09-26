using System;
using mgmtService.Functionality;
using mgmtService.Model;
using mgmtService.Service;
using Microsoft.AspNetCore.Mvc;

namespace mgmtService
{
    [ApiController]
    [Route("Api/[controller]")]
    public class UserController : ControllerBase
    {
        IUserOperation userOperation;
        public UserController()
        {
            userOperation = new UserService();
        }
        

        [HttpPost("Signup")]
        public ActionResult CreateUser(User user)
        {
            
            int temp = userOperation.CreateAccount(user);
            if (temp!=0)
            {
                return Ok("Record Added"); //Output Rendered to Browser in Json Format
            }
            else
            {
                return Ok(0);
            }
                 
        }

         [HttpPost("Login")]
        public ActionResult  Login(LoginDTO loginDTO)
        {
            int temp = userOperation.AccountValidate(loginDTO.Username, loginDTO.Password);
            if (temp!=0)
            {
                return Ok("Login Successful");  //Output Rendered to Browser in Json Format
            }
            else
            {
               return Ok(0);  
            }
                 
        }

    }
}