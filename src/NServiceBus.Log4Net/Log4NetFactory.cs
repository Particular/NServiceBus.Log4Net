namespace NServiceBus
{
    using System;
    using Logging;

    /// <summary>
    /// Configure NServiceBus logging messages to use Log4Net. Use by calling <see cref="LogManager.Use{T}"/> the T is <see cref="Log4NetFactory"/>.
    /// </summary>
    [ObsoleteEx(
        Message = "NServiceBus is now providing support for logging libraries through the Microsoft.Extensions.Logging abstraction. Remove the NServiceBus.Log4Net package. Install the NServiceBus.Extensions.Logging and Microsoft.Extensions.Logging.Log4Net.AspNetCore packages instead.",
        RemoveInVersion = "5.0.0",
        TreatAsErrorFromVersion = "4.0.0")]
    public class Log4NetFactory : LoggingFactoryDefinition
    {

        /// <summary>
        /// <see cref="LoggingFactoryDefinition.GetLoggingFactory"/>.
        /// </summary>
        protected override ILoggerFactory GetLoggingFactory()
        {
            throw new NotImplementedException("NServiceBus is now providing support for logging libraries through the Microsoft.Extensions.Logging abstraction. Remove the NServiceBus.Log4Net package. Install the NServiceBus.Extensions.Logging and Microsoft.Extensions.Logging.Log4Net.AspNetCore packages instead.");
        }

    }
}
