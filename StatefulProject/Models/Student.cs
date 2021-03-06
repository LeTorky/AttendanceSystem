// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using StatefulProject.Data;

namespace StatefulProject
{
    [Index("DepartmentId", Name = "IX_Students_DepartmentId")]
    public partial class Student
    {
        public Student()
        {
            Attendances = new HashSet<Attendance>();
            Comments = new HashSet<Comment>();
            StudentAnswers = new HashSet<StudentAnswer>();
            StudentExams = new HashSet<StudentExam>();
            StudentPermissions = new HashSet<StudentPermission>();
            User = new ApplicationUser();
        }

        [Key]
        public int StudentId { get; set; }
        public int StudentStatus { get; set; }
        [ForeignKey("User")]
        public string Id { get; set; }
        public int? DepartmentId { get; set; }
        public string Address { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }
        public string Specialization { get; set; }
        public int GraduationYear { get; set; }
        public string GraduationGrade { get; set; }
        public string Mobile { get; set; }
        public string HomePhone { get; set; }
        public string MilitaryStatusName { get; set; }
        public string Code { get; set; }

        [ForeignKey("DepartmentId")]
        [InverseProperty("Students")]
        public virtual Department Department { get; set; }
        [InverseProperty("Student")]
        public virtual Document Document { get; set; }
        [InverseProperty("Student")]
        public virtual ICollection<Attendance> Attendances { get; set; }
        [InverseProperty("Student")]
        public virtual ICollection<Comment> Comments { get; set; }
        [InverseProperty("Student")]
        public virtual ICollection<StudentAnswer> StudentAnswers { get; set; }
        [InverseProperty("Student")]
        public virtual ICollection<StudentExam> StudentExams { get; set; }
        [InverseProperty("Student")]
        public virtual ICollection<StudentPermission> StudentPermissions { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}