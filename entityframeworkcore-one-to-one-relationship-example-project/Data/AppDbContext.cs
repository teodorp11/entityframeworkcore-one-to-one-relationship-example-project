using Microsoft.EntityFrameworkCore;
using entityframeworkcore_one_to_one_relationship_example_project.Models;

namespace entityframeworkcore_one_to_one_relationship_example_project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CarCompany> CarCompanies { get; set; }
        public DbSet<CarModel> CarModels { get; set; }

    }
}
