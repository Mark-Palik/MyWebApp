namespace YouTubeApp.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public Appointment? Appointment { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
