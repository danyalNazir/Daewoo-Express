using Microsoft.AspNetCore.Mvc;
namespace Daewoo_Web_Application.View_Components
{
    [ViewComponent(Name ="ScheduleDetails")]
    public class ScheduleDetails:ViewComponent
    {
        //public string? Departure { get; set; }
        //public string? Arrival { get; set; }
        //public string? DepartureDate { get; set; }
        //public string? DepartureTime { get; set; }
        //public string? BusType { get; set; }

        public async Task<IViewComponentResult> InvokeAsync(ScheduleDetails scheduleDetails)
        {
           return View("Default", scheduleDetails);
        }
    }
}
