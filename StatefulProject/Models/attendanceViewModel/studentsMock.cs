using StatefulProject;

namespace attendanceSystemStatefulProject.Models.attendanceViewModel
{
    public class studentsMock
    {
        static IEnumerable<Student> Students = new List<Student>()
        {
            new Student(){StudentId=1},
            //new Student(){Id=2, Name="ahmed mohamed mansour adam"},
            //new Student(){Id=3, Name="Aly mohamed mansour adam"},
            //new Student(){Id=4, Name="abdelrahman mohamed mansour adam"},
            //new Student(){Id=5, Name="mohamed mohamed mansour adam"},
            //new Student(){Id=6, Name="alaa mohamed mansour adam"},
            //new Student(){Id=7, Name="youssef mohamed mansour adam"},
            //new Student(){Id=8, Name="mahmoud mohamed mansour adam"},
            //new Student(){Id=9, Name="seif mohamed mansour adam"},
            //new Student(){Id=9, Name="seif mohamed mansour adam"},
            //new Student(){Id=9, Name="seif mohamed mansour adam"},
        };
        //public static IEnumerable<Department> departments = new List<Department>()
        //{
        //    new Department(){Id=1, Name="pd", sections=new string[]{"sec1","sec2"} },
        //    new Department(){Id=2, Name="open source"},
        //    new Department(){Id=3, Name="mobile"},
        //    new Department(){Id=4, Name="machinelearning"},
        //};

        static List<Student> attended = new List<Student>();
        static List<Student> absent = new List<Student>(Students);
     

        public List<Student> getAbsentStudents(int deptID)
        {
            return absent;
        }

        public Student GetStudentByID(int id)
        {
              Student stud = Students.FirstOrDefault(d => d.StudentId == id);
              return stud;
        }
    public List<Student> GetAttendedStudents(int deptID)
        {
            return attended;
        }
        public int addAttendedStudents(IEnumerable<int> students)
        {
            //foreach (int student in students)
            //{
            //    var std= GetStudentByID(student);
            //    attended.Add(std);
            //    absent.Remove(std);
            //}
            return 1;
        }
        
        //public IEnumerable<Department> getTracks()
        //{
        //    return departments;
        //}
    }
}
