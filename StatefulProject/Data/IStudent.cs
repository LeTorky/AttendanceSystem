namespace StatefulProject.Data
{
    public interface IStudent
    {
        //Add student DB method signatures.
        IEnumerable<Student> getAbsentStudents(int deptID, DateTime date);
        IEnumerable<Student> GetAttendedStudents(int deptID, DateTime date);
        Student GetStudentByID(int id);
        void addAttendedStudents(IEnumerable<int> students, DateTime date);
        void undoAttendedStudents(IEnumerable<int> students, DateTime date);
        void AddStudent(ApplicationUser User);
    }
}
