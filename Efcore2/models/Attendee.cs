using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore2.models
{
    public class Attendee
    {
        [Key]
        public int id {  get; set; }
        
        [Required(ErrorMessage = "name is required")]
        [MaxLength(150)]
        public string FullName { get; set; } = null!;

        [Required(ErrorMessage ="email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Street is required")]
        [MaxLength(150)]
        public string Street { get; set; }

        [Required(ErrorMessage = "City is required")]
        [MaxLength(150)]
        public string City { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [MaxLength(100)]
        public string Country { get; set; }


        [Required(ErrorMessage = "PostalCode is required")]
        [MaxLength(150)]
        [Column("ZipCode")]
        public string PostalCode { get; set; }

        [NotMapped]
        public string FullAddress { get { return $"{Country}-{City}-{Street}"; } }


        //navigation

        public badge? badge { get; set; }

       

    }
}
