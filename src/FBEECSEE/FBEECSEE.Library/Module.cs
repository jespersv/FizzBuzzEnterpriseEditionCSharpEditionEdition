using Autofac;

namespace FBEECSEE.Library;

public class Module : Autofac.Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterTypeInstancePerLifetimeScope<AndOperator, IAndOperator>();
        builder.RegisterTypeInstancePerLifetimeScope<DisplayService, IDisplayService>();
        builder.RegisterTypeInstancePerLifetimeScope<EquateService, IEquateService>();
        builder.RegisterTypeInstancePerLifetimeScope<FizzBuzzLogicFactory, IFizzBuzzLogicFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<FizzBuzzLogicEvaluationMapperFactory, IFizzBuzzLogicEvaluationMapperFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<FizzBuzzLogicEvaluationFactory, IFizzBuzzLogicEvaluationFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<FizzBuzzLogicProvider, IFizzBuzzLogicProvider>();
        builder.RegisterTypeInstancePerLifetimeScope<FizzBuzzLogicEvaluationMapFactory, IFizzBuzzLogicEvaluationMapFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<FizzBuzzOperatorLogicMapFactory, IFizzBuzzOperatorLogicMapFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<FizzBuzzCollectionFactory, IFizzBuzzCollectionFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<FizzBuzzService, IFizzBuzzService>();
        builder.RegisterTypeInstancePerLifetimeScope<LogicOutputFactory, ILogicOutputFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<LoopEnumerationFactory, ILoopEnumerationFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<LogicEvaluationFactory, ILogicEvaluationFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<LoopLogicFactory, ILoopLogicFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<LoopLogicService, ILoopLogicService>();
        builder.RegisterTypeInstancePerLifetimeScope<ModulusCompareService, IModulusCompareService>();
        builder.RegisterTypeInstancePerLifetimeScope<ModulusOperator, IModulusOperator>();
    }
}