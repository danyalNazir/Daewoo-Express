using Microsoft.AspNetCore.Mvc;
using Daewoo_Web_Application.Models;

namespace Daewoo_Web_Application.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult UsersDetails()
        {
            return View(UserRepository.GetUsers());
        }

        [HttpGet]
        public ViewResult Home()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Terminals()
        {
            return View();
        }
        [HttpGet]
        public ViewResult AboutUS()
        {
            return View();
        }
        [HttpGet]
        public ViewResult ContactUS()
        {
            return View();
        }
        [HttpPost]
        public ViewResult ContactUS(Suggestion suggestion)
        {
            if(ModelState.IsValid)
            {
                //send complains to DB or mail them
                return View();
            }
            else
            return View();
        }
        [HttpGet]
        public ViewResult LahoreFeederRoute()
        {
            return View();
        }
        [HttpGet]
        public ViewResult MultanMetroBus()
        {
            return View();
        }
        [HttpGet]
        public ViewResult PeshawarBusRapidTransit()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Workshop() {
            return View();
        }
    }
}

