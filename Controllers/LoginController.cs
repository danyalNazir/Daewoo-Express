using Daewoo_Web_Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Daewoo_Web_Application.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ViewResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(User user)
        {
            if (user.Email == null || user.Password == null)
                return View();

            bool flag = UserRepository.Check_Credentials(user);
            if (flag)
            { 
                return RedirectToAction("Home","Home");
            }
            else
            {
                if (flag == false)
                    ModelState.AddModelError(string.Empty, "🛈 Unauthenticated User.");
                return View();
            }
        }


        [HttpGet]
        public ViewResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ViewResult SignUp(User user)
        {
            if (ModelState.IsValid)
            {
                int flag = UserRepository.AddUser(user);
                if (flag == 0)
                {
                    ModelState.AddModelError(string.Empty, "🛈 An account with same email already exits!");
                    return View();
                }
                else if(flag == -1)
                {
                    ModelState.AddModelError(string.Empty, "🛈 An account with same phone number already exits!");
                    return View();
                }
                else
                    return View("SignIn");
            }
            else
                return View();
        }
    }
}
