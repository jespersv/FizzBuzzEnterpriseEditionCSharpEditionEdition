using Autofac;
using NUnit.Framework;
using FBEECSEE.Library.interfaces;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

namespace FBEECSEE.Library.Tests
{
    [TestFixture]
    public class FizzBuzzModuleTests
    {
        private IContainer container;

        [SetUp]
        public void Setup()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<FizzBuzzModule>();
            container = builder.Build();
        }

        [TestCase(typeof(IAndOperator))]
        [TestCase(typeof(IDisplayService))]
        [TestCase(typeof(IEquateService))]
        [TestCase(typeof(IFizzBuzzLogicFactory))]
        [TestCase(typeof(IFizzBuzzLogicMapperFactory))]
        [TestCase(typeof(IFizzBuzzLogicService))]
        [TestCase(typeof(IFizzBuzzService))]
        [TestCase(typeof(ILogicOutputFactory))]
        [TestCase(typeof(ILoopEnumerationFactory))]
        [TestCase(typeof(ILoopEvaluationFactory))]
        [TestCase(typeof(ILoopLogicFactory))]
        [TestCase(typeof(ILoopLogicFactory))]
        [TestCase(typeof(ILoopLogicService))]
        [TestCase(typeof(IModulusCompareService))]
        [TestCase(typeof(IModulusService))]
        [TestCase(typeof(IModulusService))]
        public void Resolve_interface(Type argType)
        {
            var service = container.Resolve(argType);
            Assert.IsNotNull(service);
        }
    }
}