using Assignment_MVC_2.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Assignment_MVC_2.Context
{
    public class GymDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymMangamente;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Member>Members  { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Session> Sessions  { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<MemberShip> MemberShips { get; set; }



    }
}
