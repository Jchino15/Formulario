using Microsoft.AspNetCore.Mvc;

namespace PracticaMVC.Controllers
{
    public class EquiposController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
