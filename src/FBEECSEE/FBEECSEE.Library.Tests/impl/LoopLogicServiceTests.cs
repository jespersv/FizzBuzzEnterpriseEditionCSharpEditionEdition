using FBEECSEE.Library.entities;
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
        FizzBuzzCollection? capturedEnumeration = null;
        var input = new FizzBuzzCollection(new FizzBuzzArrayValue[] { new(1), new(5), new(10) });

        _loopLogicFactoryMock
            .Setup(x => x.CreateLoop())
            .Returns(() => loopEnumeration =>
            {
                capturedEnumeration = loopEnumeration;
                return Task.CompletedTask;
            });

        _cut.RunLoop(input);

        Assert.That(capturedEnumeration?.ToArray(), Is.EqualTo(input.ToArray()));
    }
}