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

        var configuration = new EndpointConfiguration("Log4NetTests");
        configuration.EnableInstallers();
        configuration.UseTransport<LearningTransport>();

        var endpoint = await Endpoint.Start(configuration)
            .ConfigureAwait(false);
        Assert.IsNotEmpty(LogMessageCapture.LoggingEvents);
        await endpoint.Stop()
            .ConfigureAwait(false);
    }
}