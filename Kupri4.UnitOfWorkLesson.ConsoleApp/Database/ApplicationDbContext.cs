using Kupri4.UnitOfWorkLesson.ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection;

namespace Kupri4.UnitOfWorkLesson.ConsoleApp.Database;

public class ApplicationDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Address> Address { get; set; }
    public DbSet<Pet> Pets { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.LogTo(message => Debug.WriteLine(message));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}