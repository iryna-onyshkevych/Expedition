using Excursion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Excursion.Controllers
{
    public class MapController : Controller
    {
        private ApplicationContext _context;
        public MapController(ApplicationContext context)
        {
            _context = context;
        }

        public JsonResult GetAllLocation()
        {
            var data = _context.GoogleMaps.ToList();
            return Json(data);
        }

        public IActionResult Index()
        {
            ViewBag.ListOfDropdown = _context.GoogleMaps.ToList();
            return View();
        }

        public ActionResult Register(Participant participant)
        {

            _context.Participants.Add(participant);
            _context.SaveChanges();
            return RedirectToAction("Index", "Map");
        }
    }
}
