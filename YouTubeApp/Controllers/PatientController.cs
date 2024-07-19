using YouTubeApp.Interfaces;
using Microsoft.AspNetCore.Mvc;
using YouTubeApp.Models;
namespace YouTubeApp.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientRepository _repository;
        public PatientController(IPatientRepository repository)
        {
           _repository = repository;
        }
        public IActionResult Index()
        {
            return View(_repository.GetAllPatients());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Patient patient)
        {
            _repository.CreatePatient(patient);
             _repository.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
