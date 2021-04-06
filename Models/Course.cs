using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LastLab.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string Name { get; set; }
        public virtual ICollection<Department> Departments { get; set; }

        public virtual ICollection<StudCrsGrade> Students { get; set; }
    }
}