using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Tableconfigs
{
    public class TicketConfig : BaseEntityTypeConfiguration<Ticket,Guid>
    {
        public override void Configure(EntityTypeBuilder<Ticket> builder)
        {
            base.RequireTraceable = true;
            base.UseForTraceable = true;
            base.ValueGeneratedForKey = false;

            builder.ToTable(nameof(Ticket));

            builder.HasOne(x => x.User).WithMany(x => x.Tickets).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
            builder.Property(x=>x.UserId).IsRequired();
            builder.Property(x=>x.BuyDate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(x => x.TicketNumber).IsRequired().HasMaxLength(5).HasDefaultValue(Ticket.NewTicketNumber()); 
            base.Configure(builder);

        }
    }
}
