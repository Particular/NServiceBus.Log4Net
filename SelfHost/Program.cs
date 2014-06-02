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

        var configure = Configure.With(builder => builder.EndpointName(() => "SelfHost"));
        configure.DefaultBuilder();
        configure.Serialization.Json();
        configure.UsePersistence<InMemory>();
        configure.ForInstallationOn();

        using (var bus = configure.CreateBus())
        {
            bus.Start();
            Console.WriteLine("\r\nPress any key to stop program\r\n");
            Console.Read();
            bus.Shutdown();
        }
    }

}