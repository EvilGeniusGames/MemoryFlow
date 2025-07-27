using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data.MemoryFlow
{
    public class DesignTimeMemoryFlowDbContextFactory : IDesignTimeDbContextFactory<MemoryFlowDbContext>
    {
        public MemoryFlowDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MemoryFlowDbContext>();
            optionsBuilder.UseSqlite("Data Source=./Data/MemoryFlow.db");

            return new MemoryFlowDbContext(optionsBuilder.Options);
        }
    }
}
