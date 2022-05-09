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
            return context.Students.Where(student => attendedStudentsToday.Contains(student.StudentId) == false && student.DepartmentId == deptID);
        }
       
        public IEnumerable<Student> GetAttendedStudents(int deptID, DateTime date)
        {
            var attendedStudentsToday = context.Attendances
                .Where(a => a.AttendanceDate == date)
                .Select(s => s.StudentId);
            return context.Students.Where(student => attendedStudentsToday.Contains(student.StudentId) == true && student.DepartmentId == deptID);
        }

        public int addAttendedStudents(IEnumerable<int> students, DateTime date)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentByID(int id)
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<string> getStudentsNames(IEnumerable<Student>)
        //{
        //    return context.Users
        //}
    }
}
