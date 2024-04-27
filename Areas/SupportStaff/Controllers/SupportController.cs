using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mist452FinalProject.Data;
using Mist452FinalProject.Models;
using System.Diagnostics;

namespace Mist452FinalProject.Areas.SupportStaff.Controllers
{
    [Area("SupportStaff")]
    [Authorize(Roles = "SupportStaff")]
    public class SupportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
