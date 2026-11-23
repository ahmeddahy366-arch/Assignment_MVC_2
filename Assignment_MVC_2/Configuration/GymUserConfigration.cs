using Assignment_MVC_2.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_MVC_2.Configuration
{
    public class GymUserConfigration<TUser> : IEntityTypeConfiguration<TUser> where TUser : GymUser
    {
        public void Configure(EntityTypeBuilder<TUser> builder)
        {
            builder.Property(t => t.Name).HasColumnType("varchar(50)");
            builder.Property(t => t.Email).HasColumnType("varchar(100)") ;
            builder.Property(t => t.Phone).HasColumnType("varchar(11)");


            builder.ToTable(t => t.HasCheckConstraint("Ch_EmailFormat", "Email Like '_%@_%._%'"));
            builder.ToTable(t => t.HasCheckConstraint("Ch_PhoneFormat", "LEN(Phone) = 11 AND(Phone LIKE '010%' OR Phone LIKE '011%' OR Phone LIKE '012%' OR Phone LIKE '015%')"));



builder.HasIndex(t => t.Phone).IsUnique();
            builder.HasIndex(t => t.Email).IsUnique();
            builder.ComplexProperty(t => t.Address);




        }
    }
}
