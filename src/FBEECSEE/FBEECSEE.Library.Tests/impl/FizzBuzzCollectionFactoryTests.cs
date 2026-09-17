using NUnit.Framework;
using FBEECSEE.Library.impl;
using FBEECSEE.Library.entities;
using System.Linq;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class FizzBuzzCollectionFactoryTests
{
    private FizzBuzzCollectionFactory _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _cut = new FizzBuzzCollectionFactory();
    }

    [Test]
    public void Create_ReturnsFizzBuzzCollectionWithProvidedValues()
    {
        var input = new[] { new FizzBuzzArrayValue(1), new FizzBuzzArrayValue(2), new FizzBuzzArrayValue(3) };

        var result = _cut.Create(input);

        Assert.That(result.ToArray(), Is.EqualTo(input));
    }
}
