using Microsoft.AspNetCore.Mvc;

namespace Excursion.Controllers
{
    public class HistoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
