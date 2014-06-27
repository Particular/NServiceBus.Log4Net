using System;
using NServiceBus;
using NServiceBus.Log4Net;
using NServiceBus.Persistence;

class Program
{

    static void Main()
    {
        LoggingConfig.ConfigureLog4Net();
        Log4NetConfigurator.Configure();

        var configure = Configure.With(configurationBuilder => configurationBuilder.EndpointName(() => "SelfHost"));
        configure.UseSerialization<Json>();
        configure.UsePersistence<InMemory>();
        configure.EnableInstallers();

        using (var bus = configure.CreateBus())
        {
            bus.Start();
            Console.WriteLine("\r\nPress any key to stop program\r\n");
            Console.Read();
            bus.Shutdown();
        }
    }

}