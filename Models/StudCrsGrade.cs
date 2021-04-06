using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LastLab.Models
{
    public class StudCrsGrade
    {
        [Key]
        [ForeignKey("Student")]
        [Column(Order =0)]
        public string StdId { get; set; }
        [Key]
        [ForeignKey("Course")]
        [Column(Order = 1)]
        public int CrsId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        public int Grade { get; set; }
    }
}