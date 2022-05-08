﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StatefulProject
{
    [Table("InterviewResult")]
    [Index("DeptCriteriaId", Name = "IX_InterviewResult_DeptCriteriaId")]
    [Index("IntervieweeId", Name = "IX_InterviewResult_IntervieweeId")]
    public partial class InterviewResult
    {
        [Key]
        public int Id { get; set; }
        public int Degree { get; set; }
        public int IntervieweeId { get; set; }
        public int DeptCriteriaId { get; set; }

        [ForeignKey("DeptCriteriaId")]
        [InverseProperty("InterviewResults")]
        public virtual DeptCriterion DeptCriteria { get; set; }
        [ForeignKey("IntervieweeId")]
        [InverseProperty("InterviewResults")]
        public virtual Interviewee Interviewee { get; set; }
    }
}