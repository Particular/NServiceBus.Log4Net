using System.IO;
using ApiApprover;
using NServiceBus;
using NUnit.Framework;

[TestFixture]
public class APIApprovals
{
    [Test]
    public void Approve()
    {
        Directory.SetCurrentDirectory(TestContext.CurrentContext.TestDirectory);
        PublicApiApprover.ApprovePublicApi(typeof(Log4NetFactory).Assembly);
    }

}