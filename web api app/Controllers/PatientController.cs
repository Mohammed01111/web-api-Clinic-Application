using Microsoft.AspNetCore.Mvc;
using web_api_app.Model;
using web_api_app.Repositories;

namespace web_api_app.Controllers
{
    [ApiController]
    [Route("api/patient")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepo _patientRepo;

        public PatientController(IPatientRepo patientRepo)
        {
            _patientRepo = patientRepo;
        }

        [HttpPost("add")]
        public IActionResult AddPatient(string name, int age, string gender)
        {
            var patient = new Patient
            {
                Name = name,
                Age = age,
                Gender = gender
            };
            _patientRepo.AddPatient(patient);
            return Ok("Patient added successfully");
        }

        [HttpGet("view")]
        public IActionResult GetPatients() => Ok(_patientRepo.GetPatients());
    }
}
