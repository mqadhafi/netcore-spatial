using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace netcore_spatial.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SpatialDbContext>
    {
        public SpatialDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SpatialDbContext>();
            builder.UseNpgsql("connectionstring");
            return new SpatialDbContext(builder.Options);
        }
    }
}