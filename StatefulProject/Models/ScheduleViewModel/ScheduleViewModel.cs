using Microsoft.AspNetCore.Mvc.Rendering;

namespace StatefulProject.Models.ScheduleViewModel
{
    public class ScheduleViewModel
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public SelectList Departments { get; set; }
        public int selectedDeptID { get; set; }

    }
}
