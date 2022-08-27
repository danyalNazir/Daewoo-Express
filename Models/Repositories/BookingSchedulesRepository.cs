using Daewoo_Web_Application.Models.Interfaces;
using Daewoo_Web_Application.Models;
using System.Linq;

namespace Daewoo_Web_Application.Models.Repositories
{
    public class BookingSchedulesRepository : IBookingSchedulesRepo
    {
        public List<BookingSchedule> GetBookingSchedules(PurchaseTicket ticket)
        {
            var DB = new DaewooExpressApplicationContext();                  // Making connection with DataBase Context

            var query = DB.BookingSchedules
                .Where(BS => BS.Origin.ToUpper().Trim() == ticket.Departure && BS.Destination.ToUpper().Trim() == ticket.Arrival)
                .Select(schedule => new
                {
                    schedule.ID,
                    schedule.Origin,
                    schedule.Destination,
                    schedule.Class,
                    schedule.Departure,
                    schedule.Arrival,
                    schedule.Status,
                    schedule.SeatsLeft,
                    schedule.TotalSeats,
                    schedule.Price
                });

            List<BookingSchedule>? schedules = new List<BookingSchedule>();

            if (query != null)
            {
                foreach (var s in query)
                {
                    BookingSchedule schedule = new BookingSchedule
                    {
                        ID = s.ID,
                        Origin = s.Origin,
                        Destination = s.Destination,
                        Class = s.Class,
                        Departure = s.Departure,
                        Arrival = s.Arrival,
                        Status = s.Status,
                        SeatsLeft = s.SeatsLeft,
                        TotalSeats = s.TotalSeats,
                        Price = s.Price
                    };

                    schedules.Add(schedule);
                }
                return schedules;
            }
            return schedules;
        }
    }
}
