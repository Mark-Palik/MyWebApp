namespace YouTubeApp.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime TimeOfVisit { get; set; }
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }

    }
}
