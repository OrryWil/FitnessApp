using FitnessApp.Data;
using FitnessApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Controllers
{
    public class AthletesController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly FitnessAppContext _context;

        private readonly ILogger<AthletesController> _logger;

        public AthletesController(IConfiguration configuration, FitnessAppContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        [HttpGet]
        public IActionResult AddingAthlete(int coachId)
        {
            Athletes athlete = new Athletes();
            athlete.coachid = coachId;
            ViewData["coachid"] = athlete.coachid;
            return View("AddingAthlete", athlete);
        }
        [HttpPost]
        public async Task<IActionResult> SaveAthlete(Athletes athlete)
        {
            if (athlete.firstname == null || athlete.lastname == null || athlete.email == null)
            {
                ModelState.AddModelError("", "Please fill in all fields.");
                return View("AddingAthlete", athlete);
            }
            else
            {
                
                _context.athletes.Add(athlete);
                await _context.SaveChangesAsync();
                return RedirectToAction("Dashboard", "Home", new { coachId = athlete.coachid });
            }
        }

    }
}
