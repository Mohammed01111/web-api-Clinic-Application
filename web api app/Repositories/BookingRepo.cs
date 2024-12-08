using Microsoft.EntityFrameworkCore;
using web_api_app.Model;

namespace web_api_app.Repositories
{
    public class BookingRepo : IBookingRepo
    {
        private readonly AppDbContext _context;

        public BookingRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }

        public IEnumerable<Booking> GetBookingsByClinic(int clinicId) =>
            _context.Bookings
                    .Where(b => b.CID == clinicId)
                    .Include(b => b.Patient)
                    .ToList();

        public IEnumerable<Booking> GetBookingsByPatient(int patientId) =>
            _context.Bookings
                    .Where(b => b.PID == patientId)
                    .Include(b => b.Clinic)
                    .ToList();
    }
}
