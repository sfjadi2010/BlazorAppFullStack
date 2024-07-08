using BlazorAppFullStack.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppFullStack.Data;

public class BlazorAppFullStackContext : DbContext
{
    public BlazorAppFullStackContext(DbContextOptions<BlazorAppFullStackContext> options)
        : base(options)
    {
    }

    public DbSet<Patient> Patient { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>(p =>
        {
            p.ComplexProperty(x => x.Name, x => { x.IsRequired(); });
            p.ComplexProperty(x => x.Address, x => { x.IsRequired(); });
        });

        base.OnModelCreating(modelBuilder);
    }
}
