﻿[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.5.2", FrameworkDisplayName=".NET Framework 4.5.2")]

namespace NServiceBus
{
    
    public class Log4NetFactory : NServiceBus.Logging.LoggingFactoryDefinition
    {
        public Log4NetFactory() { }
        protected override NServiceBus.Logging.ILoggerFactory GetLoggingFactory() { }
    }
}