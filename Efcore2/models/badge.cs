using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore2.models
{
    public class badge
    {

         public int Id { get; set; }

         public string BadgeNumber { get; set; }

         public DateTime IssuedDate { get; set; }

         public BadgeTier Tier { get; set; }

        public int AttendeeId { get; set; }

       
        
    }
}
