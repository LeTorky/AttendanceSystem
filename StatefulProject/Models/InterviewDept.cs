// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StatefulProject
{
    [Table("InterviewDept")]
    public partial class InterviewDept
    {
        public InterviewDept()
        {
            DeptCriteria = new HashSet<DeptCriterion>();
            Interviewees = new HashSet<Interviewee>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        [InverseProperty("Dept")]
        public virtual ICollection<DeptCriterion> DeptCriteria { get; set; }
        [InverseProperty("Dept")]
        public virtual ICollection<Interviewee> Interviewees { get; set; }
    }
}