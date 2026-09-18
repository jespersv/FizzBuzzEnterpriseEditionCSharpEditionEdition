using FBEECSEE.Library.entities;
using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;
using FBEECSEE.Library.util.functional;
using Moq;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class LoopLogicFactoryTests
{
    private Mock<ILogicEvaluationFactory> _loopEvaluationFactoryMock = null!;
    private LoopLogicFactory _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _loopEvaluationFactoryMock = new Mock<ILogicEvaluationFactory>();
        _cut = new LoopLogicFactory(_loopEvaluationFactoryMock.Object);
    }

    [Test]
    public async Task CreateLoop_EvaluatesEachLoopValue()
    {
        var processed = new List<int>();
        _loopEvaluationFactoryMock
            .Setup(x => x.Create())
            .Returns(() => value => If.Tee().If(true, () => processed.Add(value.value)).Else(() => { }).Build());

        var loop = _cut.CreateLoop();
        await loop(new FizzBuzzCollection(new FizzBuzzArrayValue[] { new(1), new(2), new(3) }));

        Assert.That(processed, Is.EqualTo(new[] { 1, 2, 3 }));
    }
}