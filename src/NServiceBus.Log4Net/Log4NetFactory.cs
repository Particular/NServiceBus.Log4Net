namespace NServiceBus.Log4Net
{
    using Logging;
    using NServiceBusLog4Net;

    /// <summary>
    /// Configure NServiceBus logging messages to use Log4Net. Use by calling <see cref="LogManager.Use{T}"/> the T is <see cref="Log4NetFactory"/>.
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