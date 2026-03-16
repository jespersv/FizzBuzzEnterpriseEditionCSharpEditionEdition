using FBEECSEE.Library.impl;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class AndOperatorTests
{
    private AndOperator _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _cut = new AndOperator();
    }

    [TestCase(true, true, true)]
    [TestCase(true, false, false)]
    [TestCase(false, true, false)]
    [TestCase(false, false, false)]
    public void And_ReturnsExpectedValue(bool v1, bool v2, bool expected)
    {
        var result = _cut.And(v1, v2);
        Assert.That(result, Is.EqualTo(expected));
    }
}