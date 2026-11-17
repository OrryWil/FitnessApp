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
                    workoutinfoid = c.workoutinfoid,
                    coachid = c.coachid,
                    workoutname = c.workoutname,
                    workoutdate = c.workoutdate,
                    workoutassignments= _context.workoutassignments
                        .Where(a => a.workoutinfoid == c.workoutinfoid)
                        .Select(a => new WorkoutAssignments
                        {
                            assignmentid = a.assignmentid,
                            workoutinfoid = a.workoutinfoid,
                            athleteid = a.athleteid,
                            athlete = _context.athletes.FirstOrDefault(ath => ath.athleteid == a.athleteid)
                        }).ToList()

                }).ToListAsync();
            
        }
        
    }
}
