using Microsoft.AspNetCore.Mvc;
using Mist452FinalProject.Data;
using Mist452FinalProject.Models

namespace Mist452FinalProject.Controllers
{
    public class GameController : Controller
    {
        private ProjectDBContext _dbContext;

        public GameController(ProjectDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
