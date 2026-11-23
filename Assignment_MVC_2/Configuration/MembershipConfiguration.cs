using Assignment_MVC_2.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_MVC_2.Configuration
{
    public class MembershipConfiguration : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(me => me.Id);
            builder.HasOne(me => me.Plan).WithMany(p => p.MemberShip);
            builder.HasOne(me => me.Member).WithMany(m => m.MemberShip);

            builder.Property(me => me.StartDate).HasDefaultValueSql("Getdate()");
        }
    }
}
