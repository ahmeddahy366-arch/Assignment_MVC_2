using Assignment_MVC_2.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_MVC_2.Configuration
{
    public class TrainerConfiguration  :  GymUserConfigration<Trainer> ,IEntityTypeConfiguration<Trainer>
    {
        public  new void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.ComplexProperty(t=>t.Address);
            builder.Property(t => t.CreateAt).HasColumnName("HireDate").HasDefaultValueSql("GETDATE()");
            builder.HasMany(t => t.sessions).WithOne(t => t.Trainer).HasForeignKey(t => t.TrainerId).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable(t => t.HasCheckConstraint("Ch_AssigntSpecialty", "speciality IN (1, 2, 3, 4)"));
            base.Configure(builder);
        }
    }
}
