using Assignment_MVC_2.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_MVC_2.Configuration
{
    public class MemberConfiguration : GymUserConfigration<Member>, IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(m => m.CreateAt).HasColumnName("JoinDate").HasDefaultValueSql("GetDate()");
            base.Configure(builder);

        }
    }
}
