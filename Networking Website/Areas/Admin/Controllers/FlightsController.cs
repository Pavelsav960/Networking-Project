using Microsoft.AspNetCore.Mvc;
using Networking_Website.Data;
using Networking_Website.Models;

namespace Networking_Website.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FlightsController : Controller
    {
        public IActionResult Index()
        {
            return View(_db.Flights.ToList());
        }

        private ApplicationDbContext _db;

        public FlightsController(ApplicationDbContext db)
        {
            this._db = db;
        }

        //Get Create method
        public IActionResult Create()
        {
            return View();
        }

        //Post Create method
        [HttpPost]
        public async Task<IActionResult> Create(Flights flights)
        {
            if (ModelState.IsValid)
            {
                _db.Flights.Add(flights);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flights);

        }

    }
}
