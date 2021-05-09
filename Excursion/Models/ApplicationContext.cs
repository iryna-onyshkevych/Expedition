using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Excursion.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
      
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<GoogleMap> GoogleMaps { get; set; }


        //public virtual DbSet<google_map> google_map { get; set; }

        public DbSet<User> AspNetUsers { get; set; }
        public DbSet<User> AspNetUserRoles { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
          : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            base.OnModelCreating(modelBuilder);
           
        }
    }
}
