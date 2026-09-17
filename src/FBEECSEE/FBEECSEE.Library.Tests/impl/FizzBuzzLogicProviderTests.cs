using FBEECSEE.Library.entities;
using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;
using Moq;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class FizzBuzzLogicProviderTests
{
    private Mock<IFizzBuzzLogicEvaluationMapperFactory> _logicMapperFactoryMock = null!;
    private FizzBuzzLogicProvider _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _logicMapperFactoryMock = new Mock<IFizzBuzzLogicEvaluationMapperFactory>();
    }

    [Test]
    public void GetEval_ExecutesMappedEvaluationWithProvidedValue()
    {
        var seenValue = -1;
        var mapper = new Dictionary<FizzBuzzEnum, EvaluationActionBinding<FizzBuzzArrayValue>>
        {
            { FizzBuzzEnum.FizzBuzz, new EvaluationActionBinding<FizzBuzzArrayValue>(_ => false, _ => { }) },
            { FizzBuzzEnum.Fizz, new EvaluationActionBinding<FizzBuzzArrayValue>(value => { seenValue = value.value; return true; }, _ => { }) },
            { FizzBuzzEnum.Buzz, new EvaluationActionBinding<FizzBuzzArrayValue>(_ => false, _ => { }) },
            { FizzBuzzEnum.NoFizzBuzz, new EvaluationActionBinding<FizzBuzzArrayValue>(_ => true, _ => { }) }
        };
        _logicMapperFactoryMock.Setup(x => x.CreateMapper()).Returns(mapper);
        _cut = new FizzBuzzLogicProvider(_logicMapperFactoryMock.Object);

        var eval = _cut.GetEval(FizzBuzzEnum.Fizz, new(11));
        var result = eval();

        Assert.That(result, Is.True);
        Assert.That(seenValue, Is.EqualTo(11));
    }

    [Test]
    public void GetResult_WithoutValue_PassesDefaultIntValue()
    {
        var seenValue = new FizzBuzzArrayValue(-1);
        var mapper = new Dictionary<FizzBuzzEnum, EvaluationActionBinding<FizzBuzzArrayValue>>
        {
            { FizzBuzzEnum.FizzBuzz, new EvaluationActionBinding<FizzBuzzArrayValue>(_ => false, _ => { }) },
            { FizzBuzzEnum.Fizz, new EvaluationActionBinding<FizzBuzzArrayValue>(_ => true, value => seenValue = value) },
            { FizzBuzzEnum.Buzz, new EvaluationActionBinding<FizzBuzzArrayValue>(_ => false, _ => { }) },
            { FizzBuzzEnum.NoFizzBuzz, new EvaluationActionBinding<FizzBuzzArrayValue>(_ => true, _ => { }) }
        };
        _logicMapperFactoryMock.Setup(x => x.CreateMapper()).Returns(mapper);
        _cut = new FizzBuzzLogicProvider(_logicMapperFactoryMock.Object);

        var action = _cut.GetResult(FizzBuzzEnum.Fizz);
        action();

        Assert.That(seenValue, Is.EqualTo(default(FizzBuzzArrayValue)));
    }

    [Test]
    public void GetResult_WithValue_PassesProvidedValue()
    {
        var seenValue = -1;
        var mapper = new Dictionary<FizzBuzzEnum, EvaluationActionBinding<FizzBuzzArrayValue>>
        {
            { FizzBuzzEnum.FizzBuzz, new EvaluationActionBinding<FizzBuzzArrayValue>(_ => false, _ => { }) },
            { FizzBuzzEnum.Fizz, new EvaluationActionBinding<FizzBuzzArrayValue>(_ => true, _ => { }) },
            { FizzBuzzEnum.Buzz, new EvaluationActionBinding<FizzBuzzArrayValue>(_ => false, _ => { }) },
            { FizzBuzzEnum.NoFizzBuzz, new EvaluationActionBinding<FizzBuzzArrayValue>(_ => true, value => seenValue = value.value) }
        };
        _logicMapperFactoryMock.Setup(x => x.CreateMapper()).Returns(mapper);
        _cut = new FizzBuzzLogicProvider(_logicMapperFactoryMock.Object);

        var action = _cut.GetResult(FizzBuzzEnum.NoFizzBuzz, new(42));
        action();

        Assert.That(seenValue, Is.EqualTo(42));
    }
}