using Microsoft.AspNetCore.Mvc;
using Networking_Website.Data;
using Networking_Website.Models;

namespace Networking_Website.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FlightTypesController : Controller
    {
        private ApplicationDbContext _db;

        public FlightTypesController(ApplicationDbContext db)
        {
            this._db = db;
        }

        public IActionResult Index()
        {
            //var data = _db.FlightTypes.ToList();
            return View(_db.FlightTypes.ToList());
        }

        //Create Get Action Method
        public ActionResult Create()
        {
            return View();
        }


        //Create Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FlightTypes flightTypes)
        {
            if(ModelState.IsValid)
            {
                _db.FlightTypes.Add(flightTypes);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flightTypes);
        }




    }
}
