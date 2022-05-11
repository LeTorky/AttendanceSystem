using Microsoft.AspNetCore.Mvc;

namespace StatefulProject.Controllers
{
    public class ScheduleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
