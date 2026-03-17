using Autofac;
using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;
using FBEECSEE.Library.util;

namespace FBEECSEE.Library;

public class FizzBuzzModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterTypeInstancePerLifetimeScope<AndOperator, IAndOperator>();
        builder.RegisterTypeInstancePerLifetimeScope<DisplayService, IDisplayService>();
        builder.RegisterTypeInstancePerLifetimeScope<EquateService, IEquateService>();
        builder.RegisterTypeInstancePerLifetimeScope<FizzBuzzLogicFactory, IFizzBuzzLogicFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<FizzBuzzLogicMapperFactory, IFizzBuzzLogicMapperFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<FizzBuzzLogicService, IFizzBuzzLogicService>();
        builder.RegisterTypeInstancePerLifetimeScope<FizzBuzzService, IFizzBuzzService>();
        builder.RegisterTypeInstancePerLifetimeScope<LogicOutputFactory, ILogicOutputFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<LoopEnumerationFactory, ILoopEnumerationFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<LoopEvaluationFactory, ILoopEvaluationFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<LoopLogicFactory, ILoopLogicFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<LoopLogicService, ILoopLogicService>();
        builder.RegisterTypeInstancePerLifetimeScope<ModulusCompareService, IModulusCompareService>();
        builder.RegisterTypeInstancePerLifetimeScope<ModulusOperator, IModulusOperator>();
    }
}