using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class DefalutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
