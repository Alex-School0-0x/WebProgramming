using Microsoft.EntityFrameworkCore;

namespace WebProgramming.Data
{
    public class TodoDbContext(DbContextOptions<TodoDbContext> options) : DbContext(options)
    {
        public DbSet<Todolist> TodoItems => Set<Todolist>();
        public DbSet<Cpr> CprItems => Set<Cpr>();


        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Todolist>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Item).IsRequired().HasMaxLength(500);
                entity.Property(e => e.IsDone).IsRequired().HasDefaultValue(false);
            });
            modelBuilder.Entity<Cpr>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.User).IsRequired().HasMaxLength(500);
                entity.Property(e => e.CprNr).IsRequired().HasMaxLength(500);
            });
        }
    }
}
