using System;
using NServiceBus;
using NServiceBus.Log4Net;
using NServiceBus.Persistence;

class Program
{

    static void Main()
    {
        LoggingConfig.ConfigureLog4Net();
        NServiceBus.Logging.LogManager.Use<Log4NetFactory>();

        var configure = Configure.With(b =>
        {
            b.EndpointName("SelfHost");
            b.UseSerialization<Json>();
            b.EnableInstallers();
        });
        configure.UsePersistence<InMemory>();

        using (var bus = configure.CreateBus())
        {
            bus.Start();
            Console.WriteLine("\r\nPress any key to stop program\r\n");
            Console.Read();
            bus.Shutdown();
        }
    }

}