﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StatefulProject
{
    public partial class Visitor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        public DateTime? VisitTime { get; set; }
        [Required]
        [Column("PId")]
        [StringLength(14)]
        public string Pid { get; set; }
        public string MobileNumber { get; set; }
        [Required]
        public string Email { get; set; }
        public int VisitDistenation { get; set; }
        public int ReasonOfVisit { get; set; }
        public int VisitorType { get; set; }
        public string Notes { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public string CurrentAcadimicYear { get; set; }
        public string ExpectedGraduationYear { get; set; }
    }
}