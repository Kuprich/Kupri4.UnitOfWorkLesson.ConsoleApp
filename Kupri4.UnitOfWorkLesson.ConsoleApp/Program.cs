using Kupri4.UnitOfWorkLesson.ConsoleApp;
using Kupri4.UnitOfWorkLesson.ConsoleApp.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder()
    .ConfigureServices((hostContext, services) =>
    {
        string connectionString = hostContext.Configuration["DbConnection"];

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlite(connectionString);
        });

        services.AddTransient<App>();
    })
    .Build();

using (var scope = host.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();
        await DbInitializer.Initialize(context);
    }
    catch (Exception)
    {
        throw;
    }
}

host.Services.GetRequiredService<App>().Run();
