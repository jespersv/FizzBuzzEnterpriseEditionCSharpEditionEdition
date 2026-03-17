using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;
using Moq;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class LoopEvaluationFactoryTests
{
    private Mock<IFizzBuzzLogicProvider> _logicServiceMock = null!;
    private LoopEvaluationFactory _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _logicServiceMock = new Mock<IFizzBuzzLogicProvider>();
        _cut = new LoopEvaluationFactory(_logicServiceMock.Object);
    }

    [Test]
    public void Create_WhenFizzBuzzIsTrue_RunsOnlyFizzBuzzAction()
    {
        var fizzBuzzCalls = 0;
        var fizzCalls = 0;
        var buzzCalls = 0;
        var noFizzBuzzCalls = 0;

        _logicServiceMock.Setup(x => x.GetEval(FizzBuzzEnum.FizzBuzz, 15)).Returns(() => true);
        _logicServiceMock.Setup(x => x.GetEval(FizzBuzzEnum.Fizz, 15)).Returns(() => true);
        _logicServiceMock.Setup(x => x.GetEval(FizzBuzzEnum.Buzz, 15)).Returns(() => true);
        _logicServiceMock.Setup(x => x.GetResult(FizzBuzzEnum.FizzBuzz)).Returns(() => fizzBuzzCalls++);
        _logicServiceMock.Setup(x => x.GetResult(FizzBuzzEnum.Fizz)).Returns(() => fizzCalls++);
        _logicServiceMock.Setup(x => x.GetResult(FizzBuzzEnum.Buzz)).Returns(() => buzzCalls++);
        _logicServiceMock.Setup(x => x.GetResult(FizzBuzzEnum.NoFizzBuzz, 15)).Returns(() => noFizzBuzzCalls++);

        var evaluator = _cut.Create();
        evaluator(15).Run();

        Assert.That(fizzBuzzCalls, Is.EqualTo(1));
        Assert.That(fizzCalls, Is.EqualTo(0));
        Assert.That(buzzCalls, Is.EqualTo(0));
        Assert.That(noFizzBuzzCalls, Is.EqualTo(0));
    }

    [Test]
    public void Create_WhenNoConditionMatches_RunsNoFizzBuzzActionWithValue()
    {
        var capturedValue = -1;

        _logicServiceMock.Setup(x => x.GetEval(FizzBuzzEnum.FizzBuzz, 7)).Returns(() => false);
        _logicServiceMock.Setup(x => x.GetEval(FizzBuzzEnum.Fizz, 7)).Returns(() => false);
        _logicServiceMock.Setup(x => x.GetEval(FizzBuzzEnum.Buzz, 7)).Returns(() => false);
        _logicServiceMock.Setup(x => x.GetResult(FizzBuzzEnum.FizzBuzz)).Returns(() => { });
        _logicServiceMock.Setup(x => x.GetResult(FizzBuzzEnum.Fizz)).Returns(() => { });
        _logicServiceMock.Setup(x => x.GetResult(FizzBuzzEnum.Buzz)).Returns(() => { });
        _logicServiceMock.Setup(x => x.GetResult(FizzBuzzEnum.NoFizzBuzz, 7)).Returns(() => capturedValue = 7);

        var evaluator = _cut.Create();
        evaluator(7).Run();

        Assert.That(capturedValue, Is.EqualTo(7));
    }
}