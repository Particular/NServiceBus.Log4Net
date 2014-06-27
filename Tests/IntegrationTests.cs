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

        var configure = Configure.With(b => b.EndpointName("Log4netTests"));
        configure.UseSerialization<Json>();
        configure.UsePersistence<InMemory>();
        configure.EnableInstallers();

        using (var bus = configure.CreateBus())
        {
            bus.Start();
            Assert.IsNotEmpty(LogMessageCapture.LoggingEvents);
        }
    }
}