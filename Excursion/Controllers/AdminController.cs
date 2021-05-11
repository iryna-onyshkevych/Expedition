using Excursion.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace Excursion.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationContext _context;
        public AdminController(ApplicationContext context)
        {
            _context = context;
        }

        private readonly string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=expeditiondb;Integrated Security=True";

        [Authorize(Roles = "superadmin, admin")]
        public IActionResult ParticipantsInfo()
        {
            List<Participant> participants = _context.Participants.ToList();
            return View(participants);
        }

        public FileStreamResult CreateFile()
        {
            string txt = string.Empty;

            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Participants"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            foreach (DataColumn column in dt.Columns)
                            {
                                txt += column.ColumnName + " ";
                            }
                            txt += "\r\n";
                            txt += "\r\n";
                            foreach (DataRow row in dt.Rows)
                            {
                                foreach (DataColumn column in dt.Columns)
                                {
                                    txt += row[column.ColumnName].ToString()+"\t ";
                                }

                                txt += "\r\n";
                            }

                        }
                       
                    }
                }
            }

            var byteArray = Encoding.ASCII.GetBytes(txt);
            var stream = new MemoryStream(byteArray);
            return File(stream, "text/plain", "ParticipantList.txt");
        }

        public JsonResult GetAllLocation()
        {
            var data = _context.GoogleMaps.ToList();
            return Json(data);
        }

        public IActionResult MapRedactor()
        {
            ViewBag.ListOfDropdown = _context.GoogleMaps.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(GoogleMap map)
        {
            _context.GoogleMaps.Add(map);
            _context.SaveChanges();
            return RedirectToAction("MapRedactor", "Admin");
        }

        [HttpPost]
        public IActionResult CurrentPoint(GoogleMap map)
        {
            foreach(var point in _context.GoogleMaps)
            {
                if (point.Id == map.Id)
                    point.Active = true;
                else
                    point.Active = false;
            }
            _context.SaveChanges();

            return RedirectToAction("MapRedactor", "Admin");
        }

        public IActionResult PointEdit(int? id)
        {
            if (id != null)
            {
                GoogleMap map = _context.GoogleMaps.FirstOrDefault(p => p.Id == id);
                if (map != null)
                    return View(map);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult PointEdit(GoogleMap map)
        {
            _context.GoogleMaps.Update(map);
            _context.SaveChanges();
            return RedirectToAction("MapRedactor", "Admin");
        }

        [HttpGet]
        [ActionName("PointDelete")]
        public IActionResult ConfirmDelete(int? id)
        {
            if (id != null)
            {
                GoogleMap map = _context.GoogleMaps.FirstOrDefault(p => p.Id == id);
                if (map != null)
                    return View(map);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult PointDelete(int? id)
        {
            if (id != null)
            {
                GoogleMap map = _context.GoogleMaps.FirstOrDefault(p => p.Id == id);
                if (map != null)
                {
                    _context.GoogleMaps.Remove(map);
                    _context.SaveChanges();
                    return RedirectToAction("MapRedactor", "Admin");
                }
            }
            return NotFound();
        }

        public ActionResult AddParticipant(Participant participant)
        {
            _context.Participants.Add(participant);
            _context.SaveChanges();
            return RedirectToAction("Index", "Map");
        }
    }
}
