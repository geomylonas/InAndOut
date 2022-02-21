using Microsoft.AspNetCore.Mvc;
using System;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //return Ok(DateTime.Now.ToShortDateString());
        }

        public IActionResult Details(int id)
        {
            return Ok("You entered id = " + id);
        }
    }
}
