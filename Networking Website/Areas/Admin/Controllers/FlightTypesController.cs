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


        //----------------

        //GET Edit Action Method
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var flightType = _db.FlightTypes.Find(id);
            if (flightType == null) 
            {
                return NotFound();
            }
            return View();
        }


        //Edit Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(FlightTypes flightTypes)
        {
            if (ModelState.IsValid)
            {
                _db.Update(flightTypes);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flightTypes);
        }


        //----------------

        //Details Get Action Method
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightType = _db.FlightTypes.Find(id);
            if (flightType == null)
            {
                return NotFound();
            }
            return View(flightType);
        }


        ////Create Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(FlightTypes flightTypes)
        {
            return RedirectToAction(nameof(Index));
        }



        //----------------

        //GET Edit Action Method
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightType = _db.FlightTypes.Find(id);

            if (flightType == null)
            {
                return NotFound();
            }
            return View(flightType);
        }


        //Edit Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id,FlightTypes flightTypes)
        {
            if(id == null)
            {
                return NotFound();
            }

            if(id!=flightTypes.Id)
            {
                return NotFound();
            }

            var flightType = _db.FlightTypes.Find(id);

            if (flightType == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Remove(flightType);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(flightTypes);
        }





    }
}
