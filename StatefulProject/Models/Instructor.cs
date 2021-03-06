// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StatefulProject
{
    public partial class Instructor
    {
        public Instructor()
        {
            Departments = new HashSet<Department>();
            StudentPermissions = new HashSet<StudentPermission>();
        }

        [Key]
        public int InstructorId { get; set; }
        public string Id { get; set; }
        public string InstName { get; set; }
        public int? DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        [InverseProperty("Instructors")]
        public virtual Department Department { get; set; }
        [InverseProperty("Supervisor")]
        public virtual ICollection<Department> Departments { get; set; }
        [InverseProperty("Instructor")]
        public virtual ICollection<StudentPermission> StudentPermissions { get; set; }
    }
}