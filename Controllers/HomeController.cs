using Microsoft.AspNetCore.Mvc;
using Daewoo_Web_Application.Models;
using Daewoo_Web_Application.Models.Interfaces;
using System.Net.Mail;
using System.Text;

namespace Daewoo_Web_Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepo _userRepo;
        private readonly ITerminalRepo _terminalRepo;

        public HomeController(IUserRepo userRepo, ITerminalRepo terminalRepo)
        {
            _userRepo = userRepo;
            _terminalRepo = terminalRepo;
        }
        [HttpGet]
        public ViewResult UsersDetails()
        {
            return View(_userRepo.GetUsers());
        }

        [HttpGet]
        public ViewResult Home()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Terminals()
        {
            return View(_terminalRepo.GetTerminals());
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
            if (ModelState.IsValid)
            {
                //send mail to admin
                SendMail(suggestion);

                ViewData["mailStatus"] = "Mail Sent Successfully!";
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
        public ViewResult Workshop()
        {
            return View();
        }



        internal void SendMail(Suggestion suggestion)
        {
            string to = "Danyalrajo19@gmail.com"; //To address    
            string from = suggestion.Email.ToString(); //From address
                                                       //
            MailMessage message = new MailMessage(from, to);

            message.Subject = $"{suggestion.Suggestion_Status.ToUpper()} about {suggestion.Suggestion_Type.ToUpper()}";
            string mailbody = $"\nTitle: {suggestion.Suggestion_Title}" +
                $"\nCustomer Name: {suggestion.UserName}" +
                $"\nCustomer Contact Number: {suggestion.Number}" +
                $"\nMessage: {suggestion.Message}";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential(from, "ojaqbgfhgxehirtw"); //two-step verification app password
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

