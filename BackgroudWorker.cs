using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ServerBrowser
{
    public class BackgroudWorker : IHostedService
    {
        private readonly ILogger<BackgroudWorker> logger;
        private int number = 0;
        private Timer timer;
        public BackgroudWorker(ILogger<BackgroudWorker> logger)
        {
            this.logger = logger;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            timer = new Timer(o => logger.LogInformation("printing from worker"),
                null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            return Task.CompletedTask;
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("printinf wooerrr");
            return Task.CompletedTask;
        }

    }
}
