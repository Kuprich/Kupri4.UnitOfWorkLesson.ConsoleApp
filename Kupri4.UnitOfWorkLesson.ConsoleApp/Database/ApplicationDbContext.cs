using Kupri4.UnitOfWorkLesson.ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Kupri4.UnitOfWorkLesson.ConsoleApp.Database;

public class ApplicationDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Address> Address { get; set; }
    public DbSet<Pet> Pets { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}

//public class ApplicationDbContextfactory : IDbContextFactory<ApplicationDbContext>
//{
//    private readonly IConfiguration _configuration;

//    public ApplicationDbContextfactory(IConfiguration configuration)
//    {
//        _configuration = configuration;
//    }
//    public ApplicationDbContext CreateDbContext()
//    {

//        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

//        string connectionString = _configuration["DbConnection"];

//        optionsBuilder.UseSqlite(connectionString);

//        return new ApplicationDbContext(optionsBuilder.Options);
//    }
//}