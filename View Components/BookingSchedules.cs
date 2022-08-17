using Microsoft.AspNetCore.Mvc;

namespace Daewoo_Web_Application.View_Components
{
    [ViewComponent(Name = "BookingSchedules")]
    public class BookingSchedules:ViewComponent
    {

        public string? Departure { get; set; }
        public string? Arrival { get; set; }
        public string? Class { get; set; }
        public string? Status { get; set; }
        public int SeatsLeft { get; set; }
        public int TotalSeats { get; set; }
        public int Price { get; set; }



        public async Task<IViewComponentResult> InvokeAsync(BookingSchedules bookingSchedules)
        {
            return View("Default", bookingSchedules);
        }
    }
}
