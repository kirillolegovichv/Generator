using Microsoft.EntityFrameworkCore;
using RandGenerator.API.Models;

namespace RandGenerator.API
{
    public class ApplicationContext : DbContext
    {
        public DbSet<GeneratedSequence> Sequences { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {

        }
    }
}
