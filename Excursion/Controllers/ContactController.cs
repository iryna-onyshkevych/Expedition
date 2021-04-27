using Microsoft.AspNetCore.Mvc;

namespace Excursion.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
