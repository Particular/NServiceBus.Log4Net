using NServiceBus;
using NUnit.Framework;
using Particular.Approvals;
using PublicApiGenerator;

[TestFixture]
public class APIApprovals
{
    [Test]
    public void Approve()
    {
#pragma warning disable 0618
        var publicApi = ApiGenerator.GeneratePublicApi(typeof(Log4NetFactory).Assembly, excludeAttributes: new[] { "System.Runtime.Versioning.TargetFrameworkAttribute" });
#pragma warning restore 0618
        Approver.Verify(publicApi);
    }
}