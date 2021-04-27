using Microsoft.AspNetCore.Mvc;

namespace Excursion.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
