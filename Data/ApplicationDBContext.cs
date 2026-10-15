using Microsoft.EntityFrameworkCore;
using sports_events.Models;
namespace sports_events.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Enrolment> Enrolments { get; set; }

        public DbSet<Category> Categories { get; set; }


    }
}
