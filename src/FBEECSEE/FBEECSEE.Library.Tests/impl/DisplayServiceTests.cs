using FBEECSEE.Library.impl;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.impl;

[TestFixture]
public class DisplayServiceTests
{
    private DisplayService _cut = null!;

    [SetUp]
    public void SetUp()
    {
        _cut = new DisplayService();
    }

    [Test]
    public void Show_WritesMessageToConsole()
    {
        var originalOut = Console.Out;
        using var writer = new StringWriter();
        Console.SetOut(writer);

        try
        {
            _cut.Show("hello");
        }
        finally
        {
            Console.SetOut(originalOut);
        }

        Assert.That(writer.ToString(), Is.EqualTo($"hello{Environment.NewLine}"));
    }
}