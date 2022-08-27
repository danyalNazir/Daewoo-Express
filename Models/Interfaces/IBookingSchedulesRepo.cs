namespace Daewoo_Web_Application.Models.Interfaces
{
    public interface IBookingSchedulesRepo
    {
        List<BookingSchedule> GetBookingSchedules(PurchaseTicket ticket);
    }
}
