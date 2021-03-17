using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EntityFramework_Core_.Net_Core_Database_First_Approach.Models.EF
{
    public partial class StudentsFee
    {
        [Key]
        public int StudentFeeId { get; set; }
        public int StudentId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }

        [ForeignKey(nameof(StudentId))]
        [InverseProperty("StudentsFees")]
        public virtual Student Student { get; set; }
    }
}
