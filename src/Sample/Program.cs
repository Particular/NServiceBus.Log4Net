using System;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;

class Program
{
    static async Task Main()
    {
        LoggingConfig.ConfigureLog4Net();
        LogManager.Use<Log4NetFactory>();

        var configuration = new EndpointConfiguration("Log4NetSample");
        configuration.EnableInstallers();
        configuration.UseTransport<LearningTransport>();

        var endpoint = await Endpoint.Start(configuration)
            .ConfigureAwait(false);
        await endpoint.SendLocal(new MyMessage())
            .ConfigureAwait(false);
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        await endpoint.Stop()
            .ConfigureAwait(false);
    }
}