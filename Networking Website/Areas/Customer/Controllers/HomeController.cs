using Microsoft.AspNetCore.Mvc;
using Networking_Website.Data;
using Networking_Website.Models;
using System.Diagnostics;

namespace Networking_Website.Areas.Customer.Controllers
{
    [Area("customer")]
    public class HomeController : Controller
    {


        private ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            this._db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Flights.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Get Book action method
        public ActionResult Detail(int? id)
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
    }
}








