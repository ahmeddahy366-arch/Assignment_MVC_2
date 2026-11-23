using Assignment_MVC_2.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_MVC_2.Configuration
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.ToTable(s => s.HasCheckConstraint("Ch_CapacityLimted25", "Capacity Between 1 and 25"));
            builder.ToTable(s => s.HasCheckConstraint("Ch_End", " EndDate > StartDate"));

        }
    }
}
