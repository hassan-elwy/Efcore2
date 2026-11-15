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
    internal class BadgeConfiguration : IEntityTypeConfiguration<badge>
    {
        public void Configure(EntityTypeBuilder<badge> builder)
        {

            builder.HasKey(x=> x.Id);   

            builder.HasIndex(x => x.Id).IsUnique();

            builder.Property(x => x.IssuedDate).IsRequired();

            builder.Property(x => x.Tier).HasConversion<string>();
                
            builder.HasOne(x => x.Attendee).
                WithOne(x => x.badge).
                HasForeignKey<badge>(x => x.AttendeeID);
        }
    }
}
