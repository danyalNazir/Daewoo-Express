using Microsoft.AspNetCore.Mvc;
using Daewoo_Web_Application.Models;
using Daewoo_Web_Application.Models.Interfaces;
//using Daewoo_Web_Application.View_Components;
namespace Daewoo_Web_Application.Controllers
{
    public class PurchaseTicketController : Controller
    {
        private readonly IBookingSchedulesRepo _repo;
        public PurchaseTicketController(IBookingSchedulesRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public ViewResult PurchaseTicket()
        {
            ViewData["AllSchedules"] = new List<BookingSchedule>();
            return View();
        }

        [HttpPost]
        public ViewResult PurchaseTicket(PurchaseTicket ticket)
        {
            ViewData["AllSchedules"] = new List<BookingSchedule>();
            if (ModelState.IsValid)
            {
                // get schedule from DB
                ViewData["AllSchedules"] = _repo.GetBookingSchedules(ticket);
                ViewData["PurchaseTicketForm"] = ticket;
                return View();
            }
            else
                return View();
        }
        //[HttpGet]
        //public ViewResult BookTicket()
        //{
        //    ViewData["BookTicketScheduleDetails"] = new ScheduleDetails();
        //    return View();
        //}
        [HttpPost]
        public ViewResult BookTicketScheduleDetails(ScheduleDetails scheduleDetails)
        {
            ViewData["BookTicketScheduleDetails"]= scheduleDetails;
            return View("BookTicket");
        }
        [HttpPost]
        public ViewResult BookTicket(BookingDetails bookingDetails)
        {
            ViewData["BookTicketScheduleDetails"] = new ScheduleDetails();
            return View("Bookings");
        }
        [HttpGet]
        public ViewResult Bookings()
        {
            return View();
        }
    }

}
