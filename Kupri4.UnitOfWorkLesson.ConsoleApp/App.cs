using Microsoft.Extensions.Hosting;

namespace Kupri4.UnitOfWorkLesson.ConsoleApp
{
    internal class App : IHostedService
    {

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Hello");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
