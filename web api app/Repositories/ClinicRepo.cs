using web_api_app.Model;

namespace web_api_app.Repositories
{
    public class ClinicRepo : IClinicRepo
    {
        private readonly AppDbContext _context;

        public ClinicRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddClinic(Clinic clinic)
        {
            _context.Clinics.Add(clinic);
            _context.SaveChanges();
        }

        public IEnumerable<Clinic> GetClinics() => _context.Clinics.ToList();

        public Clinic GetClinicBySpecialization(string specialization)
        {
            return _context.Clinics
                .FirstOrDefault(c => c.Specialization.Equals(specialization, StringComparison.OrdinalIgnoreCase));

        }

    }
}
