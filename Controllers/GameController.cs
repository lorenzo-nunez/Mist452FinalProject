using Microsoft.AspNetCore.Mvc;
using Mist452FinalProject.Data;
using Mist452FinalProject.Models;
using Microsoft.EntityFrameworkCore;

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
            var listOfGames = _dbContext.Games.ToList();


            return View(listOfGames);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Game gameobj)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Games.Add(gameobj);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(gameobj);
            
        }
        

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Game game = _dbContext.Games.Find(id);

            return View(game);
        }
        [HttpPost]
        public IActionResult Edit(int id, [Bind("CategoryID, Name, Description")] Game gameobj)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Games.Update(gameobj);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(gameobj);
        }
       
        
    }
}
