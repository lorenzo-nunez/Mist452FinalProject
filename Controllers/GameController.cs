using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mist452FinalProject.Data;
using Mist452FinalProject.Models;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mist452FinalProject.Controllers
{
    public class GameController : Controller
    {
        private readonly ProjectDBContext _dbContext;

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
        public async Task<IActionResult> Edit(int id)
        {
            var game = await _dbContext.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GameID,gameDate,opponent,score,posessionStat,shotsStat,SavesStat,foulsStat,filmURL")] Game gameobj)
        {
            if (id != gameobj.GameID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Update(gameobj);
                    await _dbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_dbContext.Games.Any(e => e.GameID == gameobj.GameID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(gameobj);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var game = await _dbContext.Games
                .FirstOrDefaultAsync(m => m.GameID == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _dbContext.Games.FindAsync(id);
            if (game != null)
            {
                _dbContext.Games.Remove(game);
                await _dbContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
