using FBEECSEE.Library.impl;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class LoopEnumerationFactoryTests
{
    private LoopEnumerationFactory _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _cut = new LoopEnumerationFactory();
    }

    [Test]
    public void CreateLoopEnumeration_ReturnsConfiguredRange()
    {
        var values = _cut.CreateLoopEnumeration().ToArray();

        Assert.That(values, Is.EqualTo(Enumerable.Range(Constants.START_LOOP_VALUE, Constants.MAXIMUM_LOOP_VALUE)));
        Assert.That(values.Length, Is.EqualTo(Constants.MAXIMUM_LOOP_VALUE));
        Assert.That(values.First(), Is.EqualTo(Constants.START_LOOP_VALUE));
        Assert.That(values.Last(), Is.EqualTo(Constants.START_LOOP_VALUE + Constants.MAXIMUM_LOOP_VALUE - 1));
    }
}