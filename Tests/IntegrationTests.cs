using NServiceBus;
using NServiceBus.Persistence;
using NUnit.Framework;

[TestFixture]
public class IntegrationTests
{
    [Test]
    public void Ensure_log_messages_are_redirected()
    {
        LogMessageCapture.ConfigureLogging();

        var busConfig = new BusConfiguration();
        busConfig.EndpointName("Log4netTests");
        busConfig.UseSerialization<JsonSerializer>();
        busConfig.EnableInstallers();
        busConfig.UsePersistence<InMemoryPersistence>();

        using (var bus = Bus.Create(busConfig))
        {
            bus.Start();
            Assert.IsNotEmpty(LogMessageCapture.LoggingEvents);
        }
    }
}