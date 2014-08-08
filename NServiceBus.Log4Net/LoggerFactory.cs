namespace NServiceBusLog4Net
{
    using System;
    using NServiceBus.Logging;

    class LoggerFactory : ILoggerFactory
    {

        public ILog GetLogger(Type type)
        {
            var logger = log4net.LogManager.GetLogger(type);
            return new Logger(logger);
        }

        public ILog GetLogger(string name)
        {
            var logger = log4net.LogManager.GetLogger(name);
            return new Logger(logger);
        }
    }
}