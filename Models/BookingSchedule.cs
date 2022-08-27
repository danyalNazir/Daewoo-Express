using System;
using System.Collections.Generic;

namespace Daewoo_Web_Application.Models
{
    public partial class BookingSchedule
    {
        public BookingSchedule()
        {
            Bookings = new HashSet<Booking>();
        }

        public int ID { get; set; }
        public string? Origin { get; set; }
        public string? Destination { get; set; }
        public string? Class { get; set; }
        public string? Departure { get; set; }
        public string? Arrival { get; set; }
        public string? Status { get; set; }
        public int SeatsLeft { get; set; }
        public int TotalSeats { get; set; }
        public int Price { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
