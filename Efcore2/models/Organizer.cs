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
        public int Id {  get; set; }

        [Required(ErrorMessage = "name must be provided ")]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [MaxLength(150)]
        public string? CompanyName { get; set; }

        //Navigation

        public ICollection<Event>? Events { get; set; }
        
        public OrganzierProfile? organzierProfile { get; set; }

        

    }
}
