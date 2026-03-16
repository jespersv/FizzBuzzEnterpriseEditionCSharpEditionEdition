using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;
using Moq;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class FizzBuzzLogicMapperFactoryTests
{
    private Mock<IFizzBuzzLogicFactory> _fizzBuzzLogicFactoryMock = null!;
    private Mock<ILogicOutputFactory> _logicOutputFactoryMock = null!;
    private FizzBuzzLogicMapperFactory _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _fizzBuzzLogicFactoryMock = new Mock<IFizzBuzzLogicFactory>();
        _logicOutputFactoryMock = new Mock<ILogicOutputFactory>();
        _cut = new FizzBuzzLogicMapperFactory(_fizzBuzzLogicFactoryMock.Object, _logicOutputFactoryMock.Object);
    }

    [Test]
    public void CreateMapper_ReturnsBindingsForAllEnums()
    {
        var mapper = _cut.CreateMapper();

        Assert.That(mapper.Keys, Is.EquivalentTo(new[] { FizzBuzzEnum.FizzBuzz, FizzBuzzEnum.Fizz, FizzBuzzEnum.Buzz, FizzBuzzEnum.NoFizzBuzz }));
    }

    [Test]
    public void CreateMapper_FizzBuzzBinding_UsesFizzBuzzFactoryAndOutput()
    {
        var outputCallCount = 0;
        _fizzBuzzLogicFactoryMock.Setup(x => x.FizzBuzzEvalLogic(15)).Returns(true);
        _logicOutputFactoryMock.Setup(x => x.FizzBuzzOutput(15)).Callback(() => outputCallCount++);
        var mapper = _cut.CreateMapper();

        var eval = mapper[FizzBuzzEnum.FizzBuzz].eval(15);
        mapper[FizzBuzzEnum.FizzBuzz].result(15);

        Assert.That(eval, Is.True);
        Assert.That(outputCallCount, Is.EqualTo(1));
    }

    [Test]
    public void CreateMapper_FizzAndBuzzBindings_UseMatchingFactoryAndOutput()
    {
        var fizzCalls = 0;
        var buzzCalls = 0;
        _fizzBuzzLogicFactoryMock.Setup(x => x.FizzEvalLogic(9)).Returns(true);
        _fizzBuzzLogicFactoryMock.Setup(x => x.BuzzEvalLogic(10)).Returns(true);
        _logicOutputFactoryMock.Setup(x => x.FizzOutput(9)).Callback(() => fizzCalls++);
        _logicOutputFactoryMock.Setup(x => x.BuzzOutput(10)).Callback(() => buzzCalls++);
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
    public void CreateMapper_NoFizzBuzzBinding_AlwaysEvaluatesTrueAndUsesNoFizzBuzzOutput()
    {
        var outputValue = -1;
        _logicOutputFactoryMock.Setup(x => x.NoFizzBuzzOutput(It.IsAny<int>())).Callback<int>(v => outputValue = v);
        var mapper = _cut.CreateMapper();

        var eval = mapper[FizzBuzzEnum.NoFizzBuzz].eval(999);
        mapper[FizzBuzzEnum.NoFizzBuzz].result(7);

        Assert.That(eval, Is.True);
        Assert.That(outputValue, Is.EqualTo(7));
    }
}