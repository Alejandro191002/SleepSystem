using Microsoft.EntityFrameworkCore;
using SleepSystem.Models;

namespace SleepSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {

        }

        public DbSet<User_> Users { get; set; }

    }
}
