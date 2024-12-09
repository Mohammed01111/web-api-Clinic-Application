using web_api_app.Model;
using web_api_app.Repositories;

namespace web_api_app.Service
{
    public class ClinicService : IClinicService
    {
        private readonly IClinicRepo _clinicRepo;

        public ClinicService(IClinicRepo clinicRepo)
        {
            _clinicRepo = clinicRepo;
        }

        public void AddClinic(Clinic clinic)
        {
            if (clinic.NumberOfSlots > 20)
                throw new Exception("A clinic cannot have more than 20 slots.");

            _clinicRepo.AddClinic(clinic);
        }

        public IEnumerable<Clinic> GetAllClinics()
        {
            return _clinicRepo.GetClinics();
        }

        public Clinic GetClinicBySpecialization(string specialization)
        {
            var clinic = _clinicRepo.GetClinicBySpecialization(specialization);
            if (clinic == null)
                throw new Exception($"No clinic found with specialization: {specialization}");

            return clinic;
        }
    }
}

