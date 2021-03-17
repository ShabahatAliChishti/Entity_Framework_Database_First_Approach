using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EntityFramework_Core_.Net_Core_Database_First_Approach.Models.EF
{
    public partial class Student
    {
        public Student()
        {
            StudentsFees = new HashSet<StudentsFee>();
        }

        [Key]
        public int StudentId { get; set; }
        [Required]
        [StringLength(250)]
        public string FullName { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Mobile { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Notes { get; set; }

        [InverseProperty(nameof(StudentsFee.Student))]
        public virtual ICollection<StudentsFee> StudentsFees { get; set; }
    }
}
