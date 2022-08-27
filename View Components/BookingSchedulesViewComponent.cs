using Microsoft.AspNetCore.Mvc;
using Daewoo_Web_Application.Models;

namespace Daewoo_Web_Application.View_Components
{
    [ViewComponent(Name = "BookingSchedules")]
    public class BookingSchedulesViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(List<BookingSchedule> schedules)
        {
            List<BookingSchedule> scheduleList = new List<BookingSchedule>();

            if (schedules.Count > 0)
            {
                foreach(BookingSchedule schedule in schedules)
                {
                    BookingSchedule bookingSchedule = new BookingSchedule
                    {
                        ID = schedule.ID,
                        Origin = schedule.Origin,
                        Destination = schedule.Destination,
                        Departure = schedule.Departure,
                        Arrival = schedule.Arrival,
                        Class = schedule.Class,
                        Status = schedule.Status,
                        SeatsLeft = schedule.SeatsLeft,
                        TotalSeats = schedule.TotalSeats,
                        Price = schedule.Price,
                    };
                    scheduleList.Add(bookingSchedule);
                }
            }
            return View("Default", scheduleList);
        }
    }
}
