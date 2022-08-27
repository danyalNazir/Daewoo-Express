using Microsoft.AspNetCore.Mvc;
using Daewoo_Web_Application.Models;
namespace Daewoo_Web_Application.View_Components
{
    [ViewComponent(Name ="ScheduleDetails")]
    public class ScheduleDetailsViewComponent:ViewComponent
    {
 
        public async Task<IViewComponentResult> InvokeAsync(ScheduleDetails scheduleDetails)
        {
            ScheduleDetails schedule=new ScheduleDetails { Departure=scheduleDetails.Departure, Arrival=scheduleDetails.Arrival,
                DepartureDate=scheduleDetails.DepartureDate, DepartureTime=scheduleDetails.DepartureTime, BusType=scheduleDetails.BusType,
                Fare=scheduleDetails.Fare, SeatsLeft=scheduleDetails.SeatsLeft, TotalSeats=scheduleDetails.TotalSeats};

           return View("Default", schedule);
        }
    }
}
