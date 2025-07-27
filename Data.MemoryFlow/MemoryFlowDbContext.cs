// File: Data.MemoryFlow/MemoryFlowDbContext.cs
using Microsoft.EntityFrameworkCore;
using Data.MemoryFlow.Entities;

namespace Data.MemoryFlow
{
    public class MemoryFlowDbContext : DbContext
    {
        public MemoryFlowDbContext()
        {
        }

        public MemoryFlowDbContext(DbContextOptions<MemoryFlowDbContext> options)
            : base(options)
        {
        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<MemoryEntry> MemoryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Setting>()
                .HasIndex(s => s.Key)
                .IsUnique();

            modelBuilder.Entity<Project>()
                .HasMany(p => p.Sessions)
                .WithOne(s => s.Project)
                .HasForeignKey(s => s.ProjectId);

            modelBuilder.Entity<Session>()
                .HasMany(s => s.Entries)
                .WithOne(e => e.Session)
                .HasForeignKey(e => e.SessionId);
        }
    }
}
