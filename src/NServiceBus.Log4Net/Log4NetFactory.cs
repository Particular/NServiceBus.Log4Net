namespace NServiceBus
{
    using Logging;
    using Logging.Log4Net;

    /// <summary>
    /// Configure NServiceBus logging messages to use Log4Net. Use by calling <see cref="LogManager.Use{T}"/> the T is <see cref="Log4NetFactory"/>.
    /// </summary>
    [ObsoleteEx(
        Message = "Support for external logging providers is no longer provided by NServiceBus providers for each logging framework. Instead, the NServiceBus.Extensions.Logging library provides the ability to use any logging provider that conforms to the Microsoft.Extensions.Logging abstraction.",
        RemoveInVersion = "5.0.0",
        TreatAsErrorFromVersion = "4.0.0")]
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