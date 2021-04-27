using Excursion.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Text;

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
            //ViewBag.Participants = _context.Participants.ToList();
            ViewBag.ListOfDropdown = _context.GoogleMaps.ToList();
            return View();
        }
      
        
        //[HttpPost]
        //public ActionResult Create(GoogleMap map)
        //{
          
        //    _context.GoogleMaps.Add(map);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index", "Map");
        //}

        public ActionResult Register(Participant participant)
        {

            _context.Participants.Add(participant);
            _context.SaveChanges();
            return RedirectToAction("Index", "Map");
        }
    }
}
