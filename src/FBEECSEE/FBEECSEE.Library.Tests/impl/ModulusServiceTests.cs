using FBEECSEE.Library.impl;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class ModulusServiceTests
{
    private ModulusService _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _cut = new ModulusService();
    }

    [TestCase(10, 3, 1)]
    [TestCase(15, 5, 0)]
    [TestCase(8, 2, 0)]
    public void Eval_ReturnsRemainder(int currentValue, int modulusValue, int expected)
    {
        var result = _cut.Eval(currentValue, modulusValue);
        Assert.That(result, Is.EqualTo(expected));
    }
}