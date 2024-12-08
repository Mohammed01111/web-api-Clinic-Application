using web_api_app.Model;

namespace web_api_app.Service
{
    public interface IPatientService
    {
        void AddPatient(Patient patient);
        IEnumerable<Patient> GetAllPatients();
    }
}
