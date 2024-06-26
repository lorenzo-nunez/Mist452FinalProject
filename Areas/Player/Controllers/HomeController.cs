using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore;
using Mist452FinalProject.Data;
using Mist452FinalProject.Models;
using System.Diagnostics;

namespace Mist452FinalProject.Areas.Player.Controllers
{
    [Area("Player")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProjectDBContext _dbContext;


        public HomeController(ILogger<HomeController> logger, ProjectDBContext projectDBContext)
        {
            _logger = logger;
            _dbContext = projectDBContext;
        }

        public IActionResult Index()
        {
            var listOfGames = _dbContext.Games.ToList();
            return View(listOfGames);
        }

        // GET: Surveys/Create
        public IActionResult CreateInfo()
        {
            return View();
        }

        // POST: Surveys/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateInfo([Bind("SurveyId,ParticipantName,Email,Age,TeamSatisfaction,FavoritePlayer,LeastFavoritePlayer,FavoriteMatch,SuggestionsForImprovement,IsInterestedInVolunteering")] Survey survey)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add(survey);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(survey);
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

        // GET: HealthSurveys/Create
        public IActionResult CreateHealth()
        {
            return View();
        }

        // POST: HealthSurveys/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateHealth([Bind("HSurveyId,ParticipantName,Weight,HeightFeet,HeightInches,Age,AppointmentDate,ReasonForCheckUp,IsSmoker")] HealthSurvey healthSurvey)
        {
            if (ModelState.IsValid)
            {
                _dbContext.HealthSurveys.Add(healthSurvey);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));  // Redirect to a suitable action
            }
            return View(healthSurvey);
        }
    }
}
