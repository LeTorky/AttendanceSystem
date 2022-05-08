﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StatefulProject
{
    [Index("DepartmentId", Name = "IX_Exams_DepartmentId")]
    [Index("SubjectId", Name = "IX_Exams_SubjectId")]
    public partial class Exam
    {
        public Exam()
        {
            ExamQuestions = new HashSet<ExamQuestion>();
            StudentExams = new HashSet<StudentExam>();
        }

        [Key]
        public int Id { get; set; }
        public string ExamName { get; set; }
        public int ExamStatus { get; set; }
        public int Duration { get; set; }
        public int SubjectId { get; set; }
        public int DepartmentId { get; set; }
        public int ExamTotalDegree { get; set; }

        [ForeignKey("DepartmentId")]
        [InverseProperty("Exams")]
        public virtual Department Department { get; set; }
        [ForeignKey("SubjectId")]
        [InverseProperty("Exams")]
        public virtual Subject Subject { get; set; }
        [InverseProperty("Exam")]
        public virtual ICollection<ExamQuestion> ExamQuestions { get; set; }
        [InverseProperty("Exam")]
        public virtual ICollection<StudentExam> StudentExams { get; set; }
    }
}