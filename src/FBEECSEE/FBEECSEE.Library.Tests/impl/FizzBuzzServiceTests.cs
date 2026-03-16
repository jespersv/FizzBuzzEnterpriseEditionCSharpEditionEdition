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
    public async Task Run_CreatesEnumerationAndExecutesLoopLogic()
    {
        var values = new[] { 1, 2, 3 };
        IEnumerable<int>? capturedEnumeration = null;
        _loopEnumerationFactoryMock.Setup(x => x.CreateLoopEnumeration()).Returns(values);
        _loopLogicServiceMock.Setup(x => x.RunLoop(It.IsAny<IEnumerable<int>>())).Callback<IEnumerable<int>>(v => capturedEnumeration = v);

        await _cut.Run();

        Assert.That(capturedEnumeration, Is.EqualTo(values));
    }
}