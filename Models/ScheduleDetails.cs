namespace Daewoo_Web_Application.Models
{
    public class ScheduleDetails
    {
        public string? Departure { get; set; }
        public string? Arrival { get; set; }
        public string? DepartureDate { get; set; }
        public string? DepartureTime { get; set; }
        public string? BusType { get; set; }
        public int Fare { get; set; }
        public int SeatsLeft { get; set; }
        public int TotalSeats { get; set; }

    }
}
