using Microsoft.EntityFrameworkCore;
using YouTubeApp.Data;
using YouTubeApp.Interfaces;
using YouTubeApp.Models;

namespace YouTubeApp.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly AppDbContext _context;
        public PatientRepository(AppDbContext context)
        {
            _context = context;
        }

        public void CreatePatient(Patient patient)
        {
            _context.Patients.Add(patient);
        }
        public void CreatePatientWithAppointment(Patient patient, Appointment appointment)
        {
            patient.Appointment = appointment;
            _context.SaveChanges();
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return _context.Patients.ToList();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
