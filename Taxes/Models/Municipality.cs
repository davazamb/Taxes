using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Taxes.Models
{
    public class Municipality
    {
        [Key]
        public int MunicipalityId { get; set; }
        [Required(ErrorMessage = "The field {0} is required")]
        [Index("Municipality_Name_Index", IsUnique = true)]
        [StringLength(50, ErrorMessage = "The field {0} can contain maxium {1} and minimum {2} characters", MinimumLength = 1)]
        [Display(Name = "Municipality Name")]
        public string Name { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}