using Microsoft.EntityFrameworkCore;
using System;

namespace Varico.EF.Models
{
    public class VaricoDbContext : DbContext
    {
        public VaricoDbContext(DbContextOptions<VaricoDbContext> options) : base(options)
        {
        }
        
        public DbSet<Users> Users { get; set; }


        public DbSet<Cars> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>()
                .HasOne(c => c.ReservedBy)
                .WithMany() 
                .HasForeignKey(c => c.ReservedById);

            base.OnModelCreating(modelBuilder);
        }
    }
}