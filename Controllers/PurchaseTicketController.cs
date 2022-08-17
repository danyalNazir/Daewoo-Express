using Microsoft.AspNetCore.Mvc;
using Daewoo_Web_Application.Models;
using Daewoo_Web_Application.View_Components;
namespace Daewoo_Web_Application.Controllers
{
    public class PurchaseTicketController : Controller
    {
        [HttpGet]
        public ViewResult PurchaseTicket()
        {
            return View();
        }

        [HttpPost]
        public ViewResult PurchaseTicket(PurchaseTicket ticket)
        {
            if (ModelState.IsValid)
            {
                // get schedule from DB
                return View(ticket);
            }
            else
                return View();
        }
        [HttpGet]
        public ViewResult BookTicket()
        {
            return View();
        }
        [HttpPost]
        public ViewResult BookTicket(BookingDetails bookingDetails)
        {
            return View("Bookings");
        }
        //[HttpGet]
        //public ViewResult Bookings()
        //{
        //    return View();
        //}
    }
    
}
