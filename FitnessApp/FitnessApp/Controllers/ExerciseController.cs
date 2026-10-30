using FitnessApp.Data;
using FitnessApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class ExerciseController : Controller
    {
        private readonly FitnessAppContext _context;
        public ExerciseController(FitnessAppContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ExercisesIndex()
        {
            var Exercise = await _context.Exercises.ToListAsync();
            return View(Exercise);
        }

        [HttpGet("GetExercises")]
        public async Task<IActionResult> GetExercises()
        {
            var exercises = await _context.Exercises.Select(x => new Exercises
            {
                exerciseid = x.exerciseid,
                exercisename = x.exercisename,
                videourl = x.videourl,
                description = x.description
            }).ToListAsync();
            return Ok(exercises);
        }

        [HttpPost("AddExercise")]
        public async Task<IActionResult> AddExercise([FromBody] Exercises exercise)
        {
            if (exercise == null)
            {
                return BadRequest("Exercise is null.");
            }
            _context.Exercises.Add(exercise);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetExercises), new { id = exercise.exerciseid }, exercise);
        }
    }
}

