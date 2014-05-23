namespace NServiceBus.Log4Net
{
    using Logging;

    /// <summary>
    /// Configure NServiceBus logging messages to use Log4Net.
    /// </summary>
    public static class Log4NetConfigurator
    {

        /// <summary>
        /// Configure NServiceBus logging messages to use Log4Net. This method should be called before <see cref="NServiceBus.Configure.With()"/>.
        /// </summary>
        public static void Configure()
        {
            var loggerFactory = new LoggerFactory();
            LogManager.LoggerFactory = loggerFactory;
        }

    }
}