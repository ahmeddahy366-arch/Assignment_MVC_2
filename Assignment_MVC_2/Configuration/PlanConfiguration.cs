using Assignment_MVC_2.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_MVC_2.Configuration
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.ToTable(p => p.HasCheckConstraint("Ch_DurationDays", "DurationDays between 1 and 365"));
        }
    }
}
