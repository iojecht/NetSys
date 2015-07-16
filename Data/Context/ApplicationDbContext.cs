using System.Data.Entity;

namespace Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base(nameOrConnectionString: "ApplicationDbContext")
        {
            
        }

        //public DbSet<Table> TableName { get; set; }
    }
}