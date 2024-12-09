using web_api_app.Model;

namespace web_api_app.Repositories
{
    public interface IBookingRepo
    {
        void AddBooking(Booking booking);
        IEnumerable<Booking> GetBookingsByClinic(int clinicId);
        IEnumerable<Booking> GetBookingsByPatient(int patientId);

       
        IEnumerable<Booking> GetAppointmentsByName(string name);
    }
}
