namespace NServiceBus.Log4Net
{
    using Logging;
    using NServiceBusLog4Net;

    /// <summary>
    /// Configure NServiceBus logging messages to use Log4Net.
    /// </summary>
    public class Log4NetFactory: LoggingFactoryDefinition
    {
        
        /// <summary>
        /// <see cref="LoggingFactoryDefinition.GetLoggingFactory"/>.
        /// </summary>
        protected override ILoggerFactory GetLoggingFactory()
        {
            return new LoggerFactory();
        }

    }
}