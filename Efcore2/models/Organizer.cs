using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore2.models
{
    [Table("EventOrganizer")]
    public class Organizer
    {
        [Required(ErrorMessage ="id must be provided")]
        public int id {  get; set; }

        [Required(ErrorMessage = "name must be provided ")]
        [MaxLength(100)]
        public string name { get; set; } = null!;

        [MaxLength(150)]
        public string? CompanyName { get; set; }

        

    }
}
