using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Linq;

using Diablo.DataAccessLayer.Data;

namespace Diablo.DataAccessLayer.Models
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {

        }

        public DataContext(string connectionString)
            : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.DatabaseGeneratedAttributeConvention>();
        }

        public DbSet<Department> Departments { get; set; }      
     
    }
}
