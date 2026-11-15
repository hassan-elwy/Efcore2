using Efcore2.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore2.Context
{
    internal class AppDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=USERK\\SQLEXPRESS;Database=EventHub;Trusted_Connection=True;Trust Server Certificate=True;");

            

        }


         public DbSet<Organizer> organizers { get; set; }

        public DbSet<Attendee>attendees { get; set; }

        public DbSet<badge> badges { get; set; }

        public DbSet<Event>events { get; set; }

        public DbSet<OrganzierProfile> organzierProfiles { get; set; }


    }
}
