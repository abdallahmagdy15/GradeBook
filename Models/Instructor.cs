using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LastLab.Models
{
    public class Instructor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        [Required, MaxLength(150)]
        public string FullName { get; set; }
        [Required, MaxLength(150)]
        public string UserName { get; set; }
        [Required, MaxLength(150)]
        public string Email { get; set; }

        [Range(18, 30, ErrorMessage = "Age must be between 18 and 30")]
        public int Age { get; set; }
        [Required]
        public Gender Gender { get; set; }

        [ForeignKey("Dept")]
        public int? DeptId { get; set; }
        [Display(Name = "Department")]
        public virtual Department Dept { get; set; }

    }
}