using FilteringSample.Model;
using FilteringSample.SqlServer.Mapping;
using Microsoft.EntityFrameworkCore;

namespace FilteringSample.SqlServer
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options) : base(options)
        {

        }

        public DbSet<Port> Ports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new PortMap(modelBuilder.Entity<Port>());
        }
    }
}
