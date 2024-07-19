using Microsoft.AspNetCore.Mvc;
using YouTubeApp.Interfaces;
using YouTubeApp.Models;
using YouTubeApp.ViewModels;

namespace YouTubeApp.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IPatientRepository _patientRepository;
        public AppointmentController(IAppointmentRepository appointmentRepository,IPatientRepository patientRepository)
        {
            _appointmentRepository = appointmentRepository;
            _patientRepository = patientRepository;
        }
        public IActionResult Index() 
        { 
            return View(_appointmentRepository.GetAllAppointments());
        }
        public IActionResult Create()
        {
            PatientAppointment patientAppointment = new PatientAppointment();
            return View(patientAppointment);
        }

        [HttpPost]
        public IActionResult Create([FromForm] Appointment appointment, [FromForm] Patient patient)
        {
            _patientRepository.CreatePatientWithAppointment(patient,appointment);
            _patientRepository.SaveChanges();
            _appointmentRepository.CreateAppointmentWithPatient(patient,appointment);
            _appointmentRepository.SaveChanges();
            
            return RedirectToAction("Index");
        }
    }
}
