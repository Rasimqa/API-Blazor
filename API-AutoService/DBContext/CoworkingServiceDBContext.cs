using API_Coworking.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Coworking.DBContext
{
    public class CoworkingServiceDBContext : DbContext
    {
        public CoworkingServiceDBContext(DbContextOptions<CoworkingServiceDBContext> options) : base(options)
        {
        }

        public DbSet<Spaces> Spaces { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<WorkPlace> WorkPlace { get; set; }
    }
}
