using Autofac;
using FBEECSEE.Library.interfaces;
using NUnit.Framework;
using System;
using System.Collections;

namespace FBEECSEE.Library.Tests;

#pragma warning disable CS8618
[TestFixture]
public class FbeecseeModuleTests
{
    private IContainer _container;

    [SetUp]
    public void Setup()
    {
        var builder = new ContainerBuilder();
        builder.RegisterModule<Module>();
        _container = builder.Build();
    }

    [TestCaseSource(typeof(TypesExpectedToBeRegisteredTestCaseSource))]
    public void Resolve_interface(Type interfaceType)
    {
        var service = _container.Resolve(interfaceType);
        Assert.That(service, Is.Not.Null);
    }

    [Test]
    public void TypesExpectedToBeRegisteredTestCaseSource_Should_NotBeEmpty()
    {
        var source = new TypesExpectedToBeRegisteredTestCaseSource();

        Assert.That(source.Any(), Is.True);
    }

    private class TypesExpectedToBeRegisteredTestCaseSource : IEnumerable<Type>
    {
        public IEnumerator<Type> GetEnumerator()
        {
            var assembly = typeof(IAndOperator).Assembly;

            return assembly
                .GetTypes()
                .Where(t =>
                    t.IsInterface &&
                    t.Namespace == "FBEECSEE.Library.interfaces")
                .GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}