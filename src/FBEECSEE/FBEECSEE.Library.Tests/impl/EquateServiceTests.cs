using FBEECSEE.Library.impl;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class EquateServiceTests
{
    private EquateService _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _cut = new EquateService();
    }

    [TestCase(1, 1, true)]
    [TestCase(1, 2, false)]
    [TestCase(-5, -5, true)]
    public void AreEqual_IntValues_ReturnsExpectedValue(int value1, int value2, bool expected)
    {
        var result = _cut.AreEqual(value1, value2);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(true, true, true)]
    [TestCase(true, false, false)]
    [TestCase(false, false, true)]
    public void AreEqual_BoolValues_ReturnsExpectedValue(bool value1, bool value2, bool expected)
    {
        var result = _cut.AreEqual(value1, value2);
        Assert.That(result, Is.EqualTo(expected));
    }
}