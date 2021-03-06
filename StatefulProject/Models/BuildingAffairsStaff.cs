// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StatefulProject
{
    public partial class BuildingAffairsStaff
    {
        public BuildingAffairsStaff()
        {
            BuildingAffairsAttendances = new HashSet<BuildingAffairsAttendance>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(14)]
        public string UserId { get; set; }
        [Required]
        public string FullNameEn { get; set; }
        [Required]
        public string FullNameAr { get; set; }
        public DateTime? BirthDate { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string HomePhone { get; set; }
        public string MilitaryStatusName { get; set; }
        public int BuildingAffairsType { get; set; }

        [InverseProperty("Staff")]
        public virtual ICollection<BuildingAffairsAttendance> BuildingAffairsAttendances { get; set; }
    }
}