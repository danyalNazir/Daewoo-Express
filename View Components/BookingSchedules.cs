using Microsoft.AspNetCore.Mvc;
using Daewoo_Web_Application.Models;

namespace Daewoo_Web_Application.View_Components
{
    [ViewComponent(Name = "BookingSchedules")]
    public class BookingSchedules : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(BookingSchedule bookingSchedule)
        {
            return View("Default", bookingSchedule);
        }
    }
}
