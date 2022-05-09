namespace StatefulProject.Data
{
    public interface IStudent
    {
        //Add student DB method signatures.
        IEnumerable<Student> getAbsentStudents(int deptID, DateTime date);
        IEnumerable<Student> GetAttendedStudents(int deptID, DateTime date);
        Student GetStudentByID(int id);
        int addAttendedStudents(IEnumerable<int> students, DateTime date);
    }
}
