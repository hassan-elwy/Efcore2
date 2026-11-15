using Efcore2.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore2.Configurations
{
    internal class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).IsRequired();

            builder.Property(x => x.Description).IsRequired();

            builder.Property(x=>x.StartDate).IsRequired();

            builder.Property(x=>x.MaxAttendees).IsRequired();

            builder.HasOne(x=>x.Organizer)
                .WithMany(x=>x.Events)
                .HasForeignKey(x=>x.OrganizerId);
        }
    }
}
