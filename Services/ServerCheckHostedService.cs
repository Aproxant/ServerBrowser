using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ServerBrowser.Entities;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ServerBrowser.Services
{
    public class ServerCheckHostedService : BackgroundService
    {
        protected IServiceProvider serviceProvider;
        public ServerCheckHostedService(IServiceProvider _serviceProvider)
        {
            serviceProvider = _serviceProvider;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
                PerformCleanup();
            }
        }
        private void PerformCleanup()
        {
            using var scope = serviceProvider.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<ServersDBContext>();
            var server = db.ServerList.Where(x => EF.Functions.DateDiffSecond(x.lastActive,DateTime.Now)>7); 
            if(server!=null)
            {
                db.RemoveRange(server);
                db.SaveChanges();
            }

            //var c = db.ServerList.Where(p => DateTime.Now.Subtract(p.lastActive).TotalDays < 30).SelectMany();
            //Console.WriteLine("ssdsd");
        }
    }
}
