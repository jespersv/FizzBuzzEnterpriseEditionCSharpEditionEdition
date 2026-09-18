using FBEECSEE.Library;
using FBEECSEE.Library.interfaces;
using Moq;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class HostServiceTests
{
    [Test]
    public async Task Run_Calls_IFizzBuzzService_Run()
    {
        var serviceMock = new Mock<IFizzBuzzService>();
        var cut = new HostService(serviceMock.Object);

        await cut.Run();

        serviceMock.Verify(x => x.Run(), Times.Once);
    }
}
