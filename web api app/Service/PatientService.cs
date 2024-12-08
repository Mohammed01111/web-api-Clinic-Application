using web_api_app.Model;
using web_api_app.Repositories;

namespace web_api_app.Service
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepo _patientRepo;

        public PatientService(IPatientRepo patientRepo)
        {
            _patientRepo = patientRepo;
        }

        public void AddPatient(Patient patient)
        {
            _patientRepo.AddPatient(patient);
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return _patientRepo.GetPatients();
        }
    }
}
