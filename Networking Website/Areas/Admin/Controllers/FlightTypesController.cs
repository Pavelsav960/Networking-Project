using Microsoft.AspNetCore.Mvc;
using Networking_Website.Data;

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
    }
}
