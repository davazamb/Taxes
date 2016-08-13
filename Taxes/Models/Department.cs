using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Taxes.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "The field {0} is required")]
        [Index("Department_Name_Index", IsUnique = true)]
        [StringLength(50, ErrorMessage = "The field {0} can contain maxium {1} and minimum {2} characters", MinimumLength = 1)]
        [Display(Name = "Department Name")]
        public string Name { get; set; }

        public virtual ICollection<Municipality> Municipalities { get; set; }
    }
}