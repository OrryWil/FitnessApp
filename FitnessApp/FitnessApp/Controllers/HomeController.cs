using FitnessApp.Data;
using FitnessApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FitnessApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly FitnessAppContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(IConfiguration configuration, FitnessAppContext context)
        {
            _configuration = configuration;
            _context = context;
        }


        public async Task<IActionResult> Index(Coaches coach)
        {
            var dbcoach = await GetCoachProfileByEmailAsync(coach.email);
            List<Athletes> dbAthletes = await GetAthlesListByCoachID(dbcoach.coachid);
            //need to figure out how to get the name of the user
            // User exists, redirect to the dashboard or home page
            if (dbcoach != null)
            {
                coach.lastname = dbcoach.lastname;
                coach.coachid = dbcoach.coachid;
                coach.phonenumber = dbcoach.phonenumber;
                coach.company = dbcoach.company;
                coach.Athletes = dbAthletes;
            }
            ViewData["coachid"] = coach.coachid;

            return View("Index", coach);
        }
         
        public async Task<IActionResult> Dashboard(int coachId)  
        {
            var dbcoach = await GetCoachProfileByCoachIdlAsync(coachId);
            List<Athletes> dbAthletes = await GetAthlesListByCoachID(coachId);
            Coaches coach = new Coaches();
            
            if (dbcoach != null)
            {
                coach.coachid = dbcoach.coachid;
                coach.lastname = dbcoach.lastname;
                coach.email = dbcoach.email;
                coach.phonenumber = dbcoach.phonenumber;
                coach.company = dbcoach.company;
                coach.Athletes = dbAthletes;
            }
            ViewData["coachid"] = coach.coachid;
            return View("Index", coach);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        public async Task<Coaches> GetCoachProfileByEmailAsync(string emailQuery)
        {
            return await _context.Coaches
                .Where(c => c.email == emailQuery)
                .Select(c => new Coaches
                {
                    coachid = c.coachid,
                    lastname = c.lastname,
                    email = c.email,
                    phonenumber = c.phonenumber,
                    company = c.company
                }).FirstOrDefaultAsync();
        }
        public async Task<List<Athletes>> GetAthlesListByCoachID(int CoachIDQuery)
        {
            return await _context.athletes
                .Where(c => c.coachid == CoachIDQuery)
                .Select(c => new Athletes
                {
                    athleteid = c.athleteid,
                    coachid = c.coachid,
                    firstname = c.firstname,
                    lastname = c.lastname,
                    email = c.email,

                }).ToListAsync();
        }
        public async Task<Coaches> GetCoachProfileByCoachIdlAsync(int CoachIDQuery)
        {
            return await _context.Coaches
                .Where(c => c.coachid == CoachIDQuery)
                .Select(c => new Coaches
                {
                    coachid = c.coachid,
                    lastname = c.lastname,
                    email = c.email,
                    phonenumber = c.phonenumber,
                    company = c.company
                }).FirstOrDefaultAsync();
        }

    }
}
