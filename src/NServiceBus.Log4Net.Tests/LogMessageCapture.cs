using System.Collections.Generic;
using log4net.Config;
using log4net.Core;
using log4net.Repository.Hierarchy;
using NServiceBus.Log4Net;
using log4netLogManager = log4net.LogManager;
using NsbLogManager = NServiceBus.Logging.LogManager;

class LogMessageCapture
{
    public static List<LoggingEvent> LoggingEvents = new List<LoggingEvent>();

    public static void ConfigureLogging()
    {
        var hierarchy = (Hierarchy)log4netLogManager.GetRepository();
        hierarchy.Root.RemoveAllAppenders();

        var target = new ActionAppender
        {
            Action = x => LoggingEvents.Add(x)
        };
        BasicConfigurator.Configure(target);
        NsbLogManager.Use<Log4NetFactory>();
    }
}