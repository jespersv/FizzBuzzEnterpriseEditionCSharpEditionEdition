using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;
using Moq;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class ModulusCompareServiceTests
{
    private Mock<IModulusOperator> _modulusServiceMock = null!;
    private Mock<IEquateService> _equateServiceMock = null!;
    private ModulusCompareService _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _modulusServiceMock = new Mock<IModulusOperator>();
        _equateServiceMock = new Mock<IEquateService>();
        _cut = new ModulusCompareService(_modulusServiceMock.Object, _equateServiceMock.Object);
    }

    [Test]
    public void Check_ReturnsTrueWhenEquateServiceReturnsTrue()
    {
        _modulusServiceMock.Setup(x => x.Eval(15, 5)).Returns(0);
        _equateServiceMock.Setup(x => x.AreEqual(0, 99)).Returns(true);

        var result = _cut.Check(15, 5, 99);

        Assert.That(result, Is.True);
        Assert.That(_modulusServiceMock.Invocations.Count, Is.EqualTo(1));
        Assert.That(_equateServiceMock.Invocations.Count, Is.EqualTo(1));
    }

    [Test]
    public void Check_UsesModulusResultAndConstantCompareValue()
    {
        _modulusServiceMock.Setup(x => x.Eval(It.IsAny<int>(), It.IsAny<int>())).Returns(2);
        _equateServiceMock.Setup(x => x.AreEqual(It.IsAny<int>(), It.IsAny<int>())).Returns(false);

        var result = _cut.Check(22, 7, 1234);

        Assert.That(result, Is.False);
        Assert.That(_equateServiceMock.Invocations[0].Arguments[0], Is.EqualTo(2));
        Assert.That(_equateServiceMock.Invocations[0].Arguments[1], Is.EqualTo(1234));
    }
}