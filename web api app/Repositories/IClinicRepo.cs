using web_api_app.Model;

namespace web_api_app.Repositories
{
    public interface IClinicRepo
    {
        void AddClinic(Clinic clinic);
        IEnumerable<Clinic> GetClinics();

        Clinic GetClinicBySpecialization(string specialization);
    }
}
