using web_api_app.Model;

namespace web_api_app.Service
{
    public interface IClinicService
    {
        void AddClinic(Clinic clinic);
        IEnumerable<Clinic> GetAllClinics();
    }
}
