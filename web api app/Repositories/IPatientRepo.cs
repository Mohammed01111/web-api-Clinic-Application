using web_api_app.Model;

namespace web_api_app.Repositories
{
    public interface IPatientRepo
    {
        void AddPatient(Patient patient);
        IEnumerable<Patient> GetPatients();
    }
}
