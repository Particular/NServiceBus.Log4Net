namespace NServiceBus.Log4Net
{
    using Logging;

    /// <summary>
    /// Configure NServiceBus logging messages to use Log4Net.
    /// </summary>
    public static class Log4NetConfigurator
    {

        /// <summary>
        /// Configure NServiceBus logging messages to use Log4Net. 
        /// </summary>
        /// <remarks>
        /// This method should be called before <see cref="NServiceBus.Configure.With()"/>.
        /// </remarks>
        public static void Configure()
        {
            var loggerFactory = new LoggerFactory();
            LogManager.LoggerFactory = loggerFactory;
        }

    }
}