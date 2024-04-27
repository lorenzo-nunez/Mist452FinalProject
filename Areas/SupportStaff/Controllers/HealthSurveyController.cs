using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mist452FinalProject.Data;
using Mist452FinalProject.Models;
using System.Threading.Tasks;

namespace Mist452FinalProject.Areas.SupportStaff.Controllers
{
    [Area("SupportStaff")]
    [Authorize(Roles = "SupportStaff")]
    public class HealthSurveysController : Controller
    {
        private readonly ProjectDBContext _dbContext;

        public HealthSurveysController(ProjectDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var healthSurveys = await _dbContext.HealthSurveys.ToListAsync();
            return View(healthSurveys);
        }

        public async Task<IActionResult> Details(int id)
        {
            var healthSurvey = await _dbContext.HealthSurveys
                .FirstOrDefaultAsync(m => m.HSurveyId == id);
            if (healthSurvey == null)
            {
                return NotFound();
            }
            return View(healthSurvey);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var healthSurvey = await _dbContext.HealthSurveys.FindAsync(id);
            if (healthSurvey == null)
            {
                return NotFound();
            }
            return View(healthSurvey);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HSurveyId,ParticipantName,Weight,HeightFeet,HeightInches,Age,AppointmentDate,ReasonForCheckUp,IsSmoker")] HealthSurvey healthSurvey)
        {
            if (id != healthSurvey.HSurveyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Update(healthSurvey);
                    await _dbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_dbContext.HealthSurveys.Any(e => e.HSurveyId == id))
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
            return View(healthSurvey);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var healthSurvey = await _dbContext.HealthSurveys
                .FirstOrDefaultAsync(m => m.HSurveyId == id);
            if (healthSurvey == null)
            {
                return NotFound();
            }
            return View(healthSurvey);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var healthSurvey = await _dbContext.HealthSurveys.FindAsync(id);
            if (healthSurvey != null)
            {
                _dbContext.HealthSurveys.Remove(healthSurvey);
                await _dbContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }


    }
}

