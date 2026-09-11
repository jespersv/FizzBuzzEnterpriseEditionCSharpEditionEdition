using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;
using Moq;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class FizzBuzzLogicEvaluationFactoryTests
{
    private Mock<IFizzBuzzLogicFactory> _fizzBuzzLogicFactoryMock = null!;
    private FizzBuzzLogicEvaluationFactory _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _fizzBuzzLogicFactoryMock = new Mock<IFizzBuzzLogicFactory>();
        _cut = new FizzBuzzLogicEvaluationFactory(_fizzBuzzLogicFactoryMock.Object);
    }

    [Test]
    public void FizzBuzzEvaluation_DelegatesToFizzBuzzLogicFactory()
    {
        _fizzBuzzLogicFactoryMock.Setup(x => x.FizzBuzzLogic(15)).Returns(true);

        var result = _cut.FizzBuzzEvaluation(15);

        Assert.That(result, Is.True);
    }

    [Test]
    public void FizzEvaluation_DelegatesToFizzLogicFactory()
    {
        _fizzBuzzLogicFactoryMock.Setup(x => x.FizzLogic(9)).Returns(true);

        var result = _cut.FizzEvaluation(9);

        Assert.That(result, Is.True);
    }

    [Test]
    public void BuzzEvaliation_DelegatesToBuzzLogicFactory()
    {
        _fizzBuzzLogicFactoryMock.Setup(x => x.BuzzLogic(10)).Returns(true);

        var result = _cut.BuzzEvaluation(10);

        Assert.That(result, Is.True);
    }

    [Test]
    public void TrueEvaluation_ReturnsTrue()
    {
        var result = _cut.TrueEvaluation(123);

        Assert.That(result, Is.True);
    }
}
