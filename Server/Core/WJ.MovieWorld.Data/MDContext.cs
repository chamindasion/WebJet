using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WJ.MovieWorld.Data
{
    public class MDContext : DbContext
    {
        public MDContext(string connectionString)
            : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();            
        }
    }
}
