using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Taxes.Models
{
    public class PropertyType
    {
        [Key]
        public int PropertyTypeId { get; set; }
        [Required(ErrorMessage = "The field {0} is required")]
        [Index("PropertyType_Description_Index", IsUnique = true)]
        [MaxLength(100, ErrorMessage = "El Campo {0} debe tener maximo {1} Caracter de longitud")]
        public string Description { get; set; }
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}