using Microsoft.AspNetCore.Mvc;
using web_api_app.Service;

namespace web_api_app.Controllers
{
    [ApiController]
    [Route("api/booking")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost("book")]
        public IActionResult BookAppointment(int patientId, int clinicId, DateTime date, int slotNumber)
        {
            _bookingService.BookAppointment(patientId, clinicId, date, slotNumber);
            return Ok("Appointment booked successfully");
        }

        [HttpGet("clinic/{clinicId}")]
        public IActionResult GetAppointmentsByClinic(int clinicId) =>
            Ok(_bookingService.GetAppointmentsByClinic(clinicId));

        [HttpGet("patient/{patientId}")]
        public IActionResult GetAppointmentsByPatient(int patientId) =>
            Ok(_bookingService.GetAppointmentsByPatient(patientId));

        [HttpGet("name/{name}")]
        public IActionResult GetAppointmentsByName(string name) =>
        Ok(_bookingService.GetAppointmentsByName(name));



    }

}
