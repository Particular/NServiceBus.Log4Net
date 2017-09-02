using System;
using log4net.Appender;
using log4net.Core;

public class ConsoleAppender : AppenderSkeleton
{
    protected override void Append(LoggingEvent loggingEvent)
    {
        Console.Write(RenderLoggingEvent(loggingEvent));
    }
}