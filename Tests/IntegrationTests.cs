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

        var configure = Configure.With(b =>
        {
            b.EndpointName("Log4netTests");
            b.UseSerialization<Json>();
            b.EnableInstallers();
            b.UsePersistence<InMemory>();
        });

        using (var bus = configure.CreateBus())
        {
            bus.Start();
            Assert.IsNotEmpty(LogMessageCapture.LoggingEvents);
        }
    }
}