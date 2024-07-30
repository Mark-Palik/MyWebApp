using Microsoft.AspNetCore.Mvc;
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
        public Patient GetPatientById(int? id)
        {
            return _context.Patients.Find(id);
        }
        public void CreatePatient(Patient patient)
        {
            _context.Patients.Add(patient);
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return _context.Patients.ToList();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public void EditPatient(Patient patient)
        {
            _context.Patients.Update(patient);
            _context.SaveChanges();
        }
        public void Remove(Patient patient)
        {
            _context.Patients.Remove(patient);
            SaveChanges();
        }
}
}
