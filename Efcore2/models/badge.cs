using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore2.models
{
    public class badge
    {
         [Key]
         public int Id { get; set; }

         public string BadgeNumber { get; set; }

         public DateTime IssuedDate { get; set; }

         public BadgeTier Tier { get; set; }

        

        //navigation
        
        public int AttendeeID { get; set; }
        public Attendee Attendee { get; set; } = null!;


        
    }
}
