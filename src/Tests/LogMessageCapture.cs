using System.Collections.Generic;
using System.Reflection;
using log4net.Config;
using log4net.Core;
using log4net.Repository.Hierarchy;
using NServiceBus;
using log4netLogManager = log4net.LogManager;
using NsbLogManager = NServiceBus.Logging.LogManager;

class LogMessageCapture
{
    public static List<LoggingEvent> LoggingEvents = new List<LoggingEvent>();

    public static void ConfigureLogging()
    {
        var repository = log4netLogManager.GetRepository(Assembly.GetCallingAssembly());
        var hierarchy = (Hierarchy)repository;
        hierarchy.Root.RemoveAllAppenders();

        var target = new ActionAppender
        {
            Action = x => LoggingEvents.Add(x)
        };
        BasicConfigurator.Configure(repository, target);
        NsbLogManager.Use<Log4NetFactory>();
    }
}