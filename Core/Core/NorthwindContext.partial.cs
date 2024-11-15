using Microsoft.EntityFrameworkCore;

namespace Core
{
    public partial class NorthwindContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // Hard-coded connection string for testing purposes
            // Database is not necessary - the error will be thrown also without a database
            optionsBuilder.UseSqlServer("Server=sql01.company.local;Database=Northwind;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=True;TrustServerCertificate=True");
        }

        public NorthwindContext()
        {

        }
    }
}
