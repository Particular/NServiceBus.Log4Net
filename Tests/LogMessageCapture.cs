using System.Collections.Generic;
using log4net;
using log4net.Config;
using log4net.Core;
using log4net.Repository.Hierarchy;
using NServiceBus.Log4Net;

class LogMessageCapture
{
    public static List<LoggingEvent> LoggingEvents = new List<LoggingEvent>();

    public static void ConfigureLogging()
    {
        var hierarchy = (Hierarchy) LogManager.GetRepository();
        hierarchy.Root.RemoveAllAppenders();

        var target = new ActionAppender
        {
            Action = x => LoggingEvents.Add(x)
        };
        BasicConfigurator.Configure(target);
        Log4NetConfigurator.Configure();
    }
}