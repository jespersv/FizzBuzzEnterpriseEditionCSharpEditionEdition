using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;
using Moq;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class LogicOutputFactoryTests
{
    private Mock<IDisplayService> _displayServiceMock = null!;
    private LogicOutputFactory _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _displayServiceMock = new Mock<IDisplayService>();
        _cut = new LogicOutputFactory(_displayServiceMock.Object);
    }

    [Test]
    public void FizzOutput_DisplaysFizzString()
    {
        var message = string.Empty;
        _displayServiceMock.Setup(x => x.Show(It.IsAny<string>())).Callback<string>(msg => message = msg);

        _cut.FizzOutput(3);

        Assert.That(message, Is.EqualTo(Constants.FIZZ_STR));
    }

    [Test]
    public void BuzzOutput_DisplaysBuzzString()
    {
        var message = string.Empty;
        _displayServiceMock.Setup(x => x.Show(It.IsAny<string>())).Callback<string>(msg => message = msg);

        _cut.BuzzOutput(5);

        Assert.That(message, Is.EqualTo(Constants.BUZZ_STR));
    }

    [Test]
    public void FizzBuzzOutput_DisplaysFizzBuzzString()
    {
        var message = string.Empty;
        _displayServiceMock.Setup(x => x.Show(It.IsAny<string>())).Callback<string>(msg => message = msg);

        _cut.FizzBuzzOutput(15);

        Assert.That(message, Is.EqualTo(Constants.FIZZBUZZ_STR));
    }

    [Test]
    public void NoFizzBuzzOutput_DisplaysValue()
    {
        var message = string.Empty;
        _displayServiceMock.Setup(x => x.Show(It.IsAny<string>())).Callback<string>(msg => message = msg);

        _cut.NoFizzBuzzOutput(7);

        Assert.That(message, Is.EqualTo("7"));
    }
}