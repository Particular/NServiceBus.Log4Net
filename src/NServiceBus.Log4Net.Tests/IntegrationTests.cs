using System.Threading.Tasks;
using NServiceBus;
using NUnit.Framework;

[TestFixture]
public class IntegrationTests
{
    [Test]
    public async Task Ensure_log_messages_are_redirected()
    {
        LogMessageCapture.ConfigureLogging();

        var endpointConfiguration = new EndpointConfiguration("Log4NetTests");
        endpointConfiguration.EnableInstallers();
        endpointConfiguration.SendFailedMessagesTo("error");
        endpointConfiguration.UseTransport<LearningTransport>();
        endpointConfiguration.UsePersistence<InMemoryPersistence>();

        var endpoint = await Endpoint.Start(endpointConfiguration);
        try
        {
            Assert.IsNotEmpty(LogMessageCapture.LoggingEvents);
        }
        finally
        {
            await endpoint.Stop();
        }
    }
}