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
    }
}
