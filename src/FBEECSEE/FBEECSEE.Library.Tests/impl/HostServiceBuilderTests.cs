using FBEECSEE.Library;
using FBEECSEE.Library.interfaces;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class HostServiceBuilderTests
{
    [Test]
    public void Build_Returns_HostService()
    {
        var host = HostServiceBuilder.Build();

        Assert.That(host, Is.Not.Null);
        Assert.That(host, Is.TypeOf<HostService>());
    }

    [Test]
    public void Build_Run_Completes()
    {
        var host = HostServiceBuilder.Build();

        Assert.DoesNotThrowAsync(async () => await host.Run());
    }
}
