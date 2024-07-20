using Microsoft.EntityFrameworkCore;
using YouTubeApp.Data;
using YouTubeApp.Interfaces;
using YouTubeApp.Models;

namespace YouTubeApp.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppDbContext _context;
        public AppointmentRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Appointment> GetAllAppointments()
        {
            return _context.Appointments.Include(p => p.Patient).ToList();
        }
        public void CreateAppointment(Appointment appointment)
        { 
            _context.Appointments.Add(appointment);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
