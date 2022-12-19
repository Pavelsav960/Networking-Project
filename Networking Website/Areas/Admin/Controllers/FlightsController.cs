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

        //GET index action method
        [HttpPost]
        public IActionResult Index(decimal? lowAmount , decimal? largeAmount)
        {
            var flights = _db.Flights.Where(c => c.Price >= lowAmount && c.Price <= largeAmount).ToList();
            if(lowAmount == null || largeAmount == null)
            {
                flights = _db.Flights.ToList();
            }
            return View(flights);
            
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

        //GET Edit method
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var flight = _db.Flights.Find(id);
            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }

        //POST edit method
        [HttpPost]
        public async Task<IActionResult> Edit(Flights flights)
        {
            if (ModelState.IsValid)
            {
                _db.Flights.Update(flights);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flights);
        }

        //GET details method
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var flight = _db.Flights.Find(id);
            if(flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }


        //GET Delete method
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var flight = _db.Flights.Find(id);
            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }

        //POST edit method
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfrim(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = _db.Flights.Find(id);

            if (flight == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Remove(flight);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(flight);
        }
    }

}
