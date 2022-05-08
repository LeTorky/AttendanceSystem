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
    }
}
