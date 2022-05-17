namespace StatefulProject.Data
{
    public class DepartmentConc:IDepartment
    {
        private ApplicationDbContext context { get; set; }
        public DepartmentConc(ApplicationDbContext _context)
        {
            this.context = _context;
        }

        //Implement IDepartment Methods.
        public IEnumerable<Department> getDepartments()
        {
            return context.Departments;
        }

        public Department getDepartmentById(int Id)
        {
            return context.Departments.Where(Dep=>Dep.Id == Id).FirstOrDefault();
        }
    }
}
