using System;
using System.Collections.Generic;

namespace Daewoo_Web_Application.Models
{
    public partial class Booking
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? BookingScheduleId { get; set; }
        public int? SeatId { get; set; }
        public string? Date { get; set; }
        public string? Time { get; set; }
        public string? BookingNumber { get; set; }

        public virtual BookingSchedule? BookingSchedule { get; set; }
        public virtual Seat? Seat { get; set; }
        public virtual User? User { get; set; }
    }
}
