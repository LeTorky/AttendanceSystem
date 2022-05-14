using Microsoft.EntityFrameworkCore;

namespace StatefulProject.Data
{
    public class StudentConc:IStudent
    {
        private ApplicationDbContext context { get; set; }
        public StudentConc(ApplicationDbContext _context)
        {
            this.context = _context;
        }

        //Implement IStudent Methods.
        public IEnumerable<Student> getAbsentStudents(int deptID, DateTime date)
        {
            var attendedStudentsToday = context.Attendances
                .Where(a => a.AttendanceDate == date)
                .Select(s=> s.StudentId);
            return context.Students.Include(s=>s.User).Where(student => attendedStudentsToday.Contains(student.StudentId) == false && student.DepartmentId == deptID && student.User!= null);
        }
       
        public IEnumerable<Student> GetAttendedStudents(int deptID, DateTime date)
        {
            var attendedStudentsToday = context.Attendances
                .Where(a => a.AttendanceDate == date)
                .Select(s => s.StudentId);
            return context.Students.Include(s => s.User).Where(student => attendedStudentsToday.Contains(student.StudentId) == true && student.DepartmentId == deptID && student.User != null);
        }

        public void addAttendedStudents(IEnumerable<int> studentsIDs, DateTime date)
        {
            TimeSpan arrivalTime = DateTime.Now.TimeOfDay;
            foreach (var id in studentsIDs)
            {
                context.Attendances.Add(new Attendance() { StudentId=id, AttendanceDate = date, ArrivalTime = arrivalTime});
                context.SaveChanges();
            }
        }

        public void undoAttendedStudents(IEnumerable<int> studentsIDs, DateTime date)
        {
            TimeSpan arrivalTime = DateTime.Now.TimeOfDay;
            foreach (var id in studentsIDs)
            {
                context.Attendances.Remove(new Attendance() { StudentId = id, AttendanceDate = date });
                context.SaveChanges();
            }
        }

        public Student GetStudentByID(int id)
        {
            throw new NotImplementedException();
        }

        public void AddStudent(ApplicationUser User)
        {
            context.Add(new Student()
            {
                Id = User.Id,
                User = User
            });
            context.SaveChanges();
        }
    }
}
