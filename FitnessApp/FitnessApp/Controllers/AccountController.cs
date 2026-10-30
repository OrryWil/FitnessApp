using FitnessApp.Models;
using FitnessApp.Data;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore; // Add this for EF Core usage

namespace FitnessApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly FitnessAppContext _context; // Add DbContext

        public AccountController(IConfiguration configuration, FitnessAppContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(Coaches coach)
        {
            string conn = _configuration.GetConnectionString("DefaultConnection");

            using (var connection = new NpgsqlConnection(conn))
            {
                string query = "SELECT COUNT(*) FROM coaches WHERE Email=@email and Passwordhash=@passwordhash";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@email", coach.email);
                    cmd.Parameters.AddWithValue("@passwordhash", coach.passwordhash);
                    
                    connection.Open();

                    object result = cmd.ExecuteScalar();

                    long count = result != null ? Convert.ToInt64(result) : 0;

                    if (count > 0)
                    {
                       
                        return RedirectToAction("Index", "Home", coach );
                    }
                    else
                    {
                        ViewBag.Message = "Invalid username or password.";

                    }
                }
            }
            return View(coach);
        }

        
    }
}
