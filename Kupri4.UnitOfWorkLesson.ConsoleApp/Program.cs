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

        services.AddHostedService<App>();
    })
    .Build();

using (var scope = host.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();
        DbInitializer.Initialize(context);
    }
    catch (Exception)
    {
        throw;
    }
}

await host.RunAsync();
   
    


//IConfigurationBuilder builder = new ConfigurationBuilder()
//    .AddJsonFile("appsettings.json", false, true);

//var configuration = builder.Build();

//ServiceCollection services = new();
//ConfigureServices(services, configuration);

//var serviceProvider = services.BuildServiceProvider();

//serviceProvider.GetRequiredService<App>().Run();


//static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
//{
//    string connectionString = configuration["DbConnection"];

//    services.AddDbContext<ApplicationDbContext>(options =>
//    {
//        options.UseSqlite(connectionString);
//    });

//    services.AddTransient<App>();
//}
