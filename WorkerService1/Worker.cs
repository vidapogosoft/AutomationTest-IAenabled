using WorkerService1.entidades;
using WorkerService1.procesos;

namespace WorkerService1
{
    public class Worker : BackgroundService
    {
        LayerRest consumo = new LayerRest();
        public List<DTOOrdenReciboRevisada> ListORR;

        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                    ListORR = await consumo.ConsumirServicio();

                    if(ListORR.Count > 0)
                    { 
                        
                    }

                }
                await Task.Delay(60000, stoppingToken);
            }
        }
    }
}
