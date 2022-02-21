using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class ItemController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
