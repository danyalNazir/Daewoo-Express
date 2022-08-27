using System;
using System.Collections.Generic;

namespace Daewoo_Web_Application.Models
{
    public partial class Seat
    {
        public Seat()
        {
            Bookings = new HashSet<Booking>();
        }

        public int ID { get; set; }
        public int? SeatNo { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
