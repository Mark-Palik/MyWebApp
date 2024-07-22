using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YouTubeApp.Models
{
    public class Appointment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AppointmentId { get; set; }
        
        public DateTime TimeOfVisit { get; set; }
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }

    }
}
