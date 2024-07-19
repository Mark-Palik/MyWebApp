using YouTubeApp.Models;
namespace YouTubeApp.Interfaces
{
    public interface IAppointmentRepository
    {
        IEnumerable<Appointment> GetAllAppointments();
        void CreateAppointment(Appointment appointment);
        void SaveChanges();
         void CreateAppointmentWithPatient(Patient patient, Appointment appointment);
    }
}
