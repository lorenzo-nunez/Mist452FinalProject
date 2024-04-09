using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mist452FinalProject.Data;
using Mist452FinalProject.Models;
using System.Diagnostics;

namespace Mist452FinalProject.Controllers
{
    public class SurveysController : Controller
    {
        private readonly ProjectDBContext _context;

        public SurveysController(ProjectDBContext context)
        {
            _context = context;
        }

        // GET: Surveys
        public async Task<IActionResult> Index()
        {
            return View(await _context.Surveys.ToListAsync());
        }

        // GET: Surveys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var survey = await _context.Surveys
                .FirstOrDefaultAsync(m => m.SurveyId == id);
            if (survey == null)
            {
                return NotFound();
            }

            return View(survey);
        }


        // GET: Surveys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Surveys/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SurveyId,ParticipantName,Email,Age,TeamSatisfaction,FavoritePlayer,LeastFavoritePlayer,FavoriteMatch,SuggestionsForImprovement,IsInterestedInVolunteering")] Survey survey)
        {
            if (ModelState.IsValid)
            {
                _context.Add(survey);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(survey);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var survey = await _context.Surveys.FindAsync(id);
            if (survey == null)
            {
                return NotFound();
            }
            return View(survey);
        }

        // POST: Surveys/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SurveyId,ParticipantName,Email,Age,TeamSatisfaction,FavoritePlayer,LeastFavoritePlayer,FavoriteMatch,SuggestionsForImprovement,IsInterestedInVolunteering")] Survey survey)
        {
            if (id != survey.SurveyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(survey);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    Debug.WriteLine($"A concurrency error occurred: {ex.Message}");
                    if (!SurveyExists(survey.SurveyId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the error more specifically here
                    Debug.WriteLine($"An error occurred: {ex.Message}");
                    ModelState.AddModelError("", "An error occurred saving the survey.");
                    return View(survey);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(survey);
        }

        private bool SurveyExists(int id)
        {
            return _context.Surveys.Any(e => e.SurveyId == id);
        }
        // GET: Surveys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var survey = await _context.Surveys
                .FirstOrDefaultAsync(m => m.SurveyId == id);
            if (survey == null)
            {
                return NotFound();
            }

            return View(survey);
        }
        // POST: Surveys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var survey = await _context.Surveys.FindAsync(id);
            _context.Surveys.Remove(survey);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }




    }
}

