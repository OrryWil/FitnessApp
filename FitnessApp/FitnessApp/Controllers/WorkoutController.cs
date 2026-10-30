using FitnessApp.Data;
using FitnessApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Controllers
{
    public class WorkoutController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly FitnessAppContext _context;

        private readonly ILogger<WorkoutController> _logger;
        public IActionResult workoutsList(int coachId)
        {
            if(coachId == -1)
            {
                return RedirectToAction("LogIn", "Account");
            }
             
        
             ViewData["coachid"] = coachId;
           
            return View();
        }
    }
}
