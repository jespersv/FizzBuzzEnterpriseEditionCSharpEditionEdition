using FBEECSEE.Library.entities;
using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;
using Moq;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class FizzBuzzLogicMapperFactoryTests
{
    private Mock<IFizzBuzzLogicMapFactory> _fizzBuzzLogicMapFactoryMock = null!;
    private FizzBuzzLogicMapperFactory _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _fizzBuzzLogicMapFactoryMock = new Mock<IFizzBuzzLogicMapFactory>();
        _cut = new FizzBuzzLogicMapperFactory(_fizzBuzzLogicMapFactoryMock.Object);
    }

    [Test]
    public void CreateMapper_ReturnsBindingsForAllEnums()
    {
        _fizzBuzzLogicMapFactoryMock.Setup(x => x.CreateFizzBuzzLogicMap()).Returns(new FizzBuzzLogicMap(FizzBuzzEnum.FizzBuzz, new EvaluationActionBinding<int>(_ => true, _ => { })));
        _fizzBuzzLogicMapFactoryMock.Setup(x => x.CreateBuzzLogicMap()).Returns(new FizzBuzzLogicMap(FizzBuzzEnum.Fizz, new EvaluationActionBinding<int>(_ => true, _ => { })));
        _fizzBuzzLogicMapFactoryMock.Setup(x => x.CreateFizzLogicMap()).Returns(new FizzBuzzLogicMap(FizzBuzzEnum.Buzz, new EvaluationActionBinding<int>(_ => true, _ => { })));
        _fizzBuzzLogicMapFactoryMock.Setup(x => x.CreateNoFizzBuzzLogicMap()).Returns(new FizzBuzzLogicMap(FizzBuzzEnum.NoFizzBuzz, new EvaluationActionBinding<int>(_ => true, _ => { })));

        var mapper = _cut.CreateMapper();

        Assert.That(mapper.Keys, Is.EquivalentTo(new[] { FizzBuzzEnum.FizzBuzz, FizzBuzzEnum.Fizz, FizzBuzzEnum.Buzz, FizzBuzzEnum.NoFizzBuzz }));
    }

    [Test]
    public void CreateMapper_UsesFizzBuzzMapFromFactory()
    {
        var resultCallCount = 0;
        _fizzBuzzLogicMapFactoryMock
            .Setup(x => x.CreateFizzBuzzLogicMap())
            .Returns(new FizzBuzzLogicMap(FizzBuzzEnum.FizzBuzz, new EvaluationActionBinding<int>(_ => true, _ => resultCallCount++)));
        _fizzBuzzLogicMapFactoryMock
            .Setup(x => x.CreateBuzzLogicMap())
            .Returns(new FizzBuzzLogicMap(FizzBuzzEnum.Fizz, new EvaluationActionBinding<int>(_ => true, _ => { })));
        _fizzBuzzLogicMapFactoryMock
            .Setup(x => x.CreateFizzLogicMap())
            .Returns(new FizzBuzzLogicMap(FizzBuzzEnum.Buzz, new EvaluationActionBinding<int>(_ => true, _ => { })));
        _fizzBuzzLogicMapFactoryMock
            .Setup(x => x.CreateNoFizzBuzzLogicMap())
            .Returns(new FizzBuzzLogicMap(FizzBuzzEnum.NoFizzBuzz, new EvaluationActionBinding<int>(_ => true, _ => { })));

        var mapper = _cut.CreateMapper();

        var eval = mapper[FizzBuzzEnum.FizzBuzz].eval(15);
        mapper[FizzBuzzEnum.FizzBuzz].result(15);

        Assert.That(eval, Is.True);
        Assert.That(resultCallCount, Is.EqualTo(1));
    }

    [Test]
    public void CreateMapper_UsesFizzAndBuzzMapsFromFactory()
    {
        var fizzCalls = 0;
        var buzzCalls = 0;
        _fizzBuzzLogicMapFactoryMock
            .Setup(x => x.CreateFizzBuzzLogicMap())
            .Returns(new FizzBuzzLogicMap(FizzBuzzEnum.FizzBuzz, new EvaluationActionBinding<int>(_ => true, _ => { })));
        _fizzBuzzLogicMapFactoryMock
            .Setup(x => x.CreateBuzzLogicMap())
            .Returns(new FizzBuzzLogicMap(FizzBuzzEnum.Fizz, new EvaluationActionBinding<int>(_ => true, _ => fizzCalls++)));
        _fizzBuzzLogicMapFactoryMock
            .Setup(x => x.CreateFizzLogicMap())
            .Returns(new FizzBuzzLogicMap(FizzBuzzEnum.Buzz, new EvaluationActionBinding<int>(_ => true, _ => buzzCalls++)));
        _fizzBuzzLogicMapFactoryMock
            .Setup(x => x.CreateNoFizzBuzzLogicMap())
            .Returns(new FizzBuzzLogicMap(FizzBuzzEnum.NoFizzBuzz, new EvaluationActionBinding<int>(_ => true, _ => { })));

        var mapper = _cut.CreateMapper();

        var fizzEval = mapper[FizzBuzzEnum.Fizz].eval(9);
        mapper[FizzBuzzEnum.Fizz].result(9);
        var buzzEval = mapper[FizzBuzzEnum.Buzz].eval(10);
        mapper[FizzBuzzEnum.Buzz].result(10);

        Assert.That(fizzEval, Is.True);
        Assert.That(buzzEval, Is.True);
        Assert.That(fizzCalls, Is.EqualTo(1));
        Assert.That(buzzCalls, Is.EqualTo(1));
    }

    [Test]
    public void CreateMapper_UsesNoFizzBuzzMapFromFactory()
    {
        var outputValue = -1;
        _fizzBuzzLogicMapFactoryMock
            .Setup(x => x.CreateFizzBuzzLogicMap())
            .Returns(new FizzBuzzLogicMap(FizzBuzzEnum.FizzBuzz, new EvaluationActionBinding<int>(_ => true, _ => { })));
        _fizzBuzzLogicMapFactoryMock
            .Setup(x => x.CreateBuzzLogicMap())
            .Returns(new FizzBuzzLogicMap(FizzBuzzEnum.Fizz, new EvaluationActionBinding<int>(_ => true, _ => { })));
        _fizzBuzzLogicMapFactoryMock
            .Setup(x => x.CreateFizzLogicMap())
            .Returns(new FizzBuzzLogicMap(FizzBuzzEnum.Buzz, new EvaluationActionBinding<int>(_ => true, _ => { })));
        _fizzBuzzLogicMapFactoryMock
            .Setup(x => x.CreateNoFizzBuzzLogicMap())
            .Returns(new FizzBuzzLogicMap(FizzBuzzEnum.NoFizzBuzz, new EvaluationActionBinding<int>(_ => true, value => outputValue = value)));

        var mapper = _cut.CreateMapper();

        var eval = mapper[FizzBuzzEnum.NoFizzBuzz].eval(999);
        mapper[FizzBuzzEnum.NoFizzBuzz].result(7);

        Assert.That(eval, Is.True);
        Assert.That(outputValue, Is.EqualTo(7));
    }
}