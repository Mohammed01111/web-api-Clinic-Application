using web_api_app.Model;

namespace web_api_app.Service
{
    public interface IBookingService
    {
        void BookAppointment(int patientId, int clinicId, DateTime date, int slotNumber);
        IEnumerable<Booking> GetAppointmentsByClinic(int clinicId);
        IEnumerable<Booking> GetAppointmentsByPatient(int patientId);
    }
}
