using FBEECSEE.Library.entities;
using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;
using Moq;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class FizzBuzzServiceTests
{
    private Mock<ILoopEnumerationFactory> _loopEnumerationFactoryMock = null!;
    private Mock<ILoopLogicService> _loopLogicServiceMock = null!;
    private FizzBuzzService _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _loopEnumerationFactoryMock = new Mock<ILoopEnumerationFactory>();
        _loopLogicServiceMock = new Mock<ILoopLogicService>();
        _cut = new FizzBuzzService(_loopEnumerationFactoryMock.Object, _loopLogicServiceMock.Object);
    }

    [Test]
    public void Run_CreatesEnumerationAndExecutesLoopLogic()
    {
        var values = new FizzBuzzArrayValue[] { new (1), new(2), new(3) };
        IEnumerable<FizzBuzzArrayValue>? capturedEnumeration = null;
        _loopEnumerationFactoryMock.Setup(x => x.CreateLoopEnumeration()).Returns(values);
        _loopLogicServiceMock.Setup(x => x.RunLoop(It.IsAny<IEnumerable<FizzBuzzArrayValue>>())).Callback<IEnumerable<FizzBuzzArrayValue>>(v => capturedEnumeration = v);

        _cut.Run();

        Assert.That(capturedEnumeration, Is.EqualTo(values));
    }
}