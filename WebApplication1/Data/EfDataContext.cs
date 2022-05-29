using Microsoft.EntityFrameworkCore;
using Models;

namespace WebApplication1.Data
{
    public class EfDataContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public EfDataContext(DbContextOptions<EfDataContext> options) : base(options)
        {

        }
    }
}
