using FBEECSEE.Library.entities;
using FBEECSEE.Library.impl;
using Moq;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class LoopEvaluationFactoryTests
{
    private Mock<IFizzBuzzOperatorLogicMapFactory> _factoryMock = null!;
    private LoopEvaluationFactory _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _factoryMock = new Mock<IFizzBuzzOperatorLogicMapFactory>();
        _cut = new LoopEvaluationFactory(_factoryMock.Object);
    }

    [Test]
    public void Create_WhenFizzBuzzConditionMatches_RunsOnlyFizzBuzzAction()
    {
        var fizzBuzzCalls = 0;
        var fizzCalls = 0;
        var buzzCalls = 0;
        var noFizzBuzzCalls = 0;

        _factoryMock.Setup(x => x.GetFizzBuzz()).Returns(new FizzBuzzOperatorLogicMap(_ => () => true, _ => () => fizzBuzzCalls++));
        _factoryMock.Setup(x => x.GetFizz()).Returns(new FizzBuzzOperatorLogicMap(_ => () => true, _ => () => fizzCalls++));
        _factoryMock.Setup(x => x.GetBuzz()).Returns(new FizzBuzzOperatorLogicMap(_ => () => true, _ => () => buzzCalls++));
        _factoryMock.Setup(x => x.GetNoFizzBuzz()).Returns(new FizzBuzzOperatorLogicMap(_ => () => true, _ => () => noFizzBuzzCalls++));

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

        _factoryMock.Setup(x => x.GetFizzBuzz()).Returns(new FizzBuzzOperatorLogicMap(_ => () => false, _ => () => { }));
        _factoryMock.Setup(x => x.GetFizz()).Returns(new FizzBuzzOperatorLogicMap(_ => () => false, _ => () => { }));
        _factoryMock.Setup(x => x.GetBuzz()).Returns(new FizzBuzzOperatorLogicMap(_ => () => false, _ => () => { }));
        _factoryMock.Setup(x => x.GetNoFizzBuzz()).Returns(new FizzBuzzOperatorLogicMap(_ => () => true, value => () => capturedValue = value));

        var evaluator = _cut.Create();
        evaluator(7).Run();

        Assert.That(capturedValue, Is.EqualTo(7));
    }
}