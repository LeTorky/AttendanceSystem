using attendanceSystemStatefulProject.Models.attendanceViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StatefulProject.Data;

namespace attendanceSystem.Controllers
{
    public class AttendanceController : Controller
    {
        attendanceViewModel vmodel = new attendanceViewModel();
        studentsMock studentsMock = new studentsMock();

        IStudent StudentConc;
        IDepartment DepartmentConc;
        public AttendanceController(IStudent _StudentConc, IDepartment _DepartmentConc)
        {
            StudentConc = _StudentConc;
            DepartmentConc = _DepartmentConc;
        }
        
        public IActionResult Index(DateTime date, int selectedDeptID, bool saved)
        {
            //get the absent students of the selected dept
            if (selectedDeptID != 0 || saved == true)
            {
                vmodel.Absentstudents = StudentConc.getAbsentStudents(selectedDeptID, date);
                vmodel.Attendedstudents = StudentConc.GetAttendedStudents(selectedDeptID, date);
                vmodel.date = date;
            }
            else
            {
                //assign the date
                vmodel.date = DateTime.Today;
            }
            //get the departments for the drop down
            var departments = DepartmentConc.getDepartments();
            //assign the drop down list
            vmodel.tracks = new SelectList(departments, "Id", "ShortName");
            return View(vmodel);
        }

        [HttpPost]
        public IActionResult Save(int[] studentsIDs)
        {
            studentsMock.addAttendedStudents(studentsIDs);
            RedirectToRoute(nameof(Index), new { saved = true });
            //return RedirectToRoute(nameof(Index), new { saved = true });
            //return Redirect(nameof(Index));
            return Ok();
        }
    }
}
