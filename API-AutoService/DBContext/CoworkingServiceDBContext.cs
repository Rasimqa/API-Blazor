using API_BlazorForSome.Models;
using Microsoft.EntityFrameworkCore;

namespace API_BlazorForSome.DBContext
{
    public class ArmyPetServiceDBContext : DbContext
    {
        public ArmyPetServiceDBContext(DbContextOptions<ArmyPetServiceDBContext> options) : base(options)
        {
        }

        public DbSet<Spaces> Spaces { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<WorkPlace> WorkPlace { get; set; }
        public DbSet<MedCard> MedCard { get; set; }
        public DbSet<Mischief> Mischief { get; set; }
        public DbSet<Pet> Pet { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
    }
}
