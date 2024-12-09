using Microsoft.AspNetCore.Mvc;
using web_api_app.Model;
using web_api_app.Repositories;

namespace web_api_app.Controllers
{
    [ApiController]
    [Route("api/clinic")]
    public class ClinicController : ControllerBase
    {
        private readonly IClinicRepo _clinicRepo;

        public ClinicController(IClinicRepo clinicRepo)
        {
            _clinicRepo = clinicRepo;
        }

        [HttpPost("add")]
        public IActionResult AddClinic(string Specialization, int maxslots)
        {
            var clinic = new Clinic{
                Specialization = Specialization,   
                NumberOfSlots = maxslots    

            };

            _clinicRepo.AddClinic(clinic);
            return Ok("Clinic added successfully");
        }



        [HttpGet("view/specialization")]
        public IActionResult GetClinicBySpecialization(string specialization)
        {
            var clinic = _clinicRepo.GetClinics().FirstOrDefault(c => c.Specialization.Equals(specialization, StringComparison.OrdinalIgnoreCase));
            if (clinic == null)
            {
                return NotFound($"No clinic found with specialization: {specialization}");
            }
            return Ok(clinic);
        }

        [HttpGet("view")]
        public IActionResult GetClinics() => Ok(_clinicRepo.GetClinics());

    }
}
