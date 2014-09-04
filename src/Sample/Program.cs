using System;
using NServiceBus;
using NServiceBus.Log4Net;

class Program
{

    static void Main()
    {
        LoggingConfig.ConfigureLog4Net();
        NServiceBus.Logging.LogManager.Use<Log4NetFactory>();

        var busConfig = new BusConfiguration();
        busConfig.EndpointName("Log4netSample");
        busConfig.UseSerialization<JsonSerializer>();
        busConfig.EnableInstallers();
        busConfig.UsePersistence<InMemoryPersistence>();

        using (var bus = Bus.Create(busConfig))
        {
            bus.Start();
            Console.WriteLine("\r\nPress any key to stop program\r\n");
            Console.Read();
        }
    }

}