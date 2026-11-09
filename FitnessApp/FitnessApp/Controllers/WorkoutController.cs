using FitnessApp.Data;
using FitnessApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Controllers
{
    public class WorkoutController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly FitnessAppContext _context;

        private readonly ILogger<WorkoutController> _logger;

        public WorkoutController(FitnessAppContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> workoutsList(int coachId)
        {
            if(coachId == -1)
            {
                return RedirectToAction("LogIn", "Account");
            }

            List<WorkoutInfo> dbworkoutInfo =  await GetWorkoutsInfoListByCoachID(coachId);
             ViewData["coachid"] = coachId;
           
            return View(dbworkoutInfo);
        }

        public async Task<List<WorkoutInfo>> GetWorkoutsInfoListByCoachID(int CoachIDQuery)
        {
            return await _context.workoutinfo
                .Where(c => c.coachid == CoachIDQuery)
                .Select(c => new WorkoutInfo
                {
                    workoutid = c.workoutid,
                    coachid = c.coachid,
                    workoutname = c.workoutname,
                    workoutdate = c.workoutdate

                }).ToListAsync();
        }
    }
}
