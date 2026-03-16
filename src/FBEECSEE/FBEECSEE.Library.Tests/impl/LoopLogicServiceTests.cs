using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;
using Moq;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class LoopLogicServiceTests
{
    private Mock<ILoopLogicFactory> _loopLogicFactoryMock = null!;
    private LoopLogicService _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _loopLogicFactoryMock = new Mock<ILoopLogicFactory>();
        _cut = new LoopLogicService(_loopLogicFactoryMock.Object);
    }

    [Test]
    public void RunLoop_ExecutesLoopFactoryDelegate()
    {
        IEnumerable<int>? capturedEnumeration = null;
        var input = new[] { 1, 5, 10 };

        _loopLogicFactoryMock
            .Setup(x => x.CreateLoop())
            .Returns(() => loopEnumeration =>
            {
                capturedEnumeration = loopEnumeration;
                return Task.CompletedTask;
            });

        _cut.RunLoop(input);

        Assert.That(capturedEnumeration, Is.EqualTo(input));
    }
}