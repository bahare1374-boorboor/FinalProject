using Microsoft.EntityFrameworkCore;
using Model.DomainModels;

namespace Model
{
    public class FinalProjectDbContext : DbContext
    {
        public FinalProjectDbContext(DbContextOptions options) : base(options)
        {

        }
        public FinalProjectDbContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=FinalProjectDb;Integrated Security=True;MultipleActiveResultSets=True;Encrypt=False");
            //Data Source =.; Initial Catalog = XYZ; Integrated Security = True; Trust Server Certificate = True
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
