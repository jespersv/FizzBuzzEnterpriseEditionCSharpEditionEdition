using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;
using Moq;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class FizzBuzzLogicFactoryTests
{
    private Mock<IModulusCompareService> _modulusCompareServiceMock = null!;
    private Mock<IAndOperator> _andOperatorMock = null!;
    private FizzBuzzLogicFactory _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _modulusCompareServiceMock = new Mock<IModulusCompareService>();
        _andOperatorMock = new Mock<IAndOperator>();
        _cut = new FizzBuzzLogicFactory(_modulusCompareServiceMock.Object, _andOperatorMock.Object);
    }

    [Test]
    public void FizzEvalLogic_UsesFizzValue()
    {
        _modulusCompareServiceMock.Setup(x => x.Check(9, Constants.FIZZVALUE, Constants.MODULE_FIZZBUZZ_SHOULD_EQUAL)).Returns(true);

        var result = _cut.FizzEvalLogic(9);

        Assert.That(result, Is.True);
        Assert.That(_modulusCompareServiceMock.Invocations.Count, Is.EqualTo(1));
    }

    [Test]
    public void BuzzEvalLogic_UsesBuzzValue()
    {
        _modulusCompareServiceMock.Setup(x => x.Check(10, Constants.BUZZVALUE, Constants.MODULE_FIZZBUZZ_SHOULD_EQUAL)).Returns(true);

        var result = _cut.BuzzEvalLogic(10);

        Assert.That(result, Is.True);
        Assert.That(_modulusCompareServiceMock.Invocations.Count, Is.EqualTo(1));
    }

    [Test]
    public void FizzBuzzEvalLogic_CombinesFizzAndBuzzEvaluationsWithAndOperator()
    {
        var andLeft = false;
        var andRight = false;

        _modulusCompareServiceMock
            .Setup(x => x.Check(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>()))
            .Returns<int, int, int>((_, value, _) => value == Constants.FIZZVALUE);

        _andOperatorMock
            .Setup(x => x.And(It.IsAny<bool>(), It.IsAny<bool>()))
            .Callback<bool, bool>((v1, v2) =>
            {
                andLeft = v1;
                andRight = v2;
            })
            .Returns(false);

        var result = _cut.FizzBuzzEvalLogic(9);

        Assert.That(result, Is.False);
        Assert.That(andLeft, Is.True);
        Assert.That(andRight, Is.False);
        Assert.That(_modulusCompareServiceMock.Invocations.Count, Is.EqualTo(2));
    }
}