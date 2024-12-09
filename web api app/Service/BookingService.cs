﻿using web_api_app.Model;
using web_api_app.Repositories;

namespace web_api_app.Service
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepo _bookingRepo;

        public BookingService(IBookingRepo bookingRepo)
        {
            _bookingRepo = bookingRepo;
        }

        public void BookAppointment(int patientId, int clinicId, DateTime date, int slotNumber)
        {
            if (slotNumber < 1 || slotNumber > 20)
                throw new Exception("Slot number must be between 1 and 20");

            var booking = new Booking
            {
                PID = patientId,
                CID = clinicId,
                Date = date,
                SlotNumber = slotNumber
            };

            _bookingRepo.AddBooking(booking);
        }

        public IEnumerable<Booking> GetAppointmentsByClinic(int clinicId) =>
            _bookingRepo.GetBookingsByClinic(clinicId);

        public IEnumerable<Booking> GetAppointmentsByPatient(int patientId) =>
            _bookingRepo.GetBookingsByPatient(patientId);

        public IEnumerable<Booking> GetAppointmentsByName(string name) =>
        _bookingRepo.GetAppointmentsByName(name);



    }

}