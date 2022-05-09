using Microsoft.AspNetCore.Identity;
using StatefulProject.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatefulProject.Data
{
    public class ApplicationUser:IdentityUser
    {
        [ForeignKey("Student")]
        public int Id { get; set; }
        public string UserName { get; set; }
        public virtual Student Student { get; set; }
    }
}
