using FBEECSEE.Library.entities;
using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;
using Moq;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class FizzBuzzOperatorLogicMapFactoryTests
{
    private Mock<IFizzBuzzLogicProvider> _logicProviderMock = null!;
    private FizzBuzzOperatorLogicMapFactory _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _logicProviderMock = new Mock<IFizzBuzzLogicProvider>();
        _cut = new FizzBuzzOperatorLogicMapFactory(_logicProviderMock.Object);
    }

    [Test]
    public void GetFizzBuzz_UsesFizzBuzzProviderEvaluationAndResult()
    {
        var resultCalled = false;
        _logicProviderMock.Setup(x => x.GetEval(FizzBuzzEnum.FizzBuzz, 15)).Returns(() => true);
        _logicProviderMock.Setup(x => x.GetResult(FizzBuzzEnum.FizzBuzz)).Returns(() => resultCalled = true);

        var map = _cut.GetFizzBuzz();

        Assert.That(map.ConditionEval(15)(), Is.True);
        map.Function(15)();
        Assert.That(resultCalled, Is.True);
    }

    [Test]
    public void GetFizz_UsesFizzProviderEvaluationAndResult()
    {
        var resultCalled = false;
        _logicProviderMock.Setup(x => x.GetEval(FizzBuzzEnum.Fizz, 9)).Returns(() => true);
        _logicProviderMock.Setup(x => x.GetResult(FizzBuzzEnum.Fizz)).Returns(() => resultCalled = true);

        var map = _cut.GetFizz();

        Assert.That(map.ConditionEval(9)(), Is.True);
        map.Function(9)();
        Assert.That(resultCalled, Is.True);
    }

    [Test]
    public void GetBuzz_UsesBuzzProviderEvaluationAndResult()
    {
        var resultCalled = false;
        _logicProviderMock.Setup(x => x.GetEval(FizzBuzzEnum.Buzz, 10)).Returns(() => true);
        _logicProviderMock.Setup(x => x.GetResult(FizzBuzzEnum.Buzz)).Returns(() => resultCalled = true);

        var map = _cut.GetBuzz();

        Assert.That(map.ConditionEval(10)(), Is.True);
        map.Function(10)();
        Assert.That(resultCalled, Is.True);
    }

    [Test]
    public void GetNoFizzBuzz_UsesNoFizzBuzzProviderEvaluationAndResultWithValue()
    {
        var resultValue = -1;
        _logicProviderMock.Setup(x => x.GetEval(FizzBuzzEnum.NoFizzBuzz, 7)).Returns(() => true);
        _logicProviderMock.Setup(x => x.GetResult(FizzBuzzEnum.NoFizzBuzz, 7)).Returns(() => resultValue = 7);

        var map = _cut.GetNoFizzBuzz();

        Assert.That(map.ConditionEval(7)(), Is.True);
        map.Function(7)();
        Assert.That(resultValue, Is.EqualTo(7));
    }
}
