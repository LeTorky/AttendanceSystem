using Microsoft.AspNetCore.Mvc;
using StatefulProject.Models.ScheduleViewModel;

namespace StatefulProject.Controllers
{
    public class ScheduleController : Controller
    {
        ScheduleViewModel vmodel = new ScheduleViewModel();

        public IActionResult Index(int selectedDeptID)
        {

            return View(vmodel);
        }
    }
}
