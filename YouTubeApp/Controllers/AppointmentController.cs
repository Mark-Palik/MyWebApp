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
        public IActionResult Create(string searchString)
        {
            var patients = _patientRepository.GetAllPatients();
            patients = patients.Where(p => p.LastName.Contains(searchString));
            return View(patients);
        }

        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            
            
            return RedirectToAction("Index");
        }
    }
}
