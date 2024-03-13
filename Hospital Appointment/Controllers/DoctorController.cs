using Hospital_Appointment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Appointment.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult BookAppointment()
        {
            SampleDataDoctor sample = new SampleDataDoctor();

            var results = sample.doctors.ToList();
            return View(results);
        }

        public IActionResult CompleteAppointment(int id)
        {
            SampleDataDoctor sample = new SampleDataDoctor();
           
            return View(sample.doctors.First(e => e.Id == id));
        }
    }
}
