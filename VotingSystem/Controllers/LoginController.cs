using Microsoft.AspNetCore.Mvc;
using VotingSystem.Models;
using VotingSystem.Services;

namespace VotingSystem.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)
        {
            SecurityService securityService = new SecurityService();
         
            if (securityService.IsValid(userModel)) 
            {
                return View("LoginSucces", userModel);
            } else
            {
                return View("LoginFailure", userModel);
            }
         
        }
    }
}
