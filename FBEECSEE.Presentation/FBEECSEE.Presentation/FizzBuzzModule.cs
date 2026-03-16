using Autofac;
using FBEECSEE.Presentation.impl;
using FBEECSEE.Presentation.interfaces;
using FBEECSEE.Presentation.util;

namespace FBEECSEE.Presentation;

public class FizzBuzzModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterTypeInstancePerLifetimeScope<FizzBuzzService, IFizzBuzzService>();
        builder.RegisterTypeInstancePerLifetimeScope<LoopEnumerationFactory, ILoopEnumerationFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<DisplayService, IDisplayService>();
        builder.RegisterTypeInstancePerLifetimeScope<EquateService, IEquateService>();
        builder.RegisterTypeInstancePerLifetimeScope<FizzBuzzLogicFactory, IFizzBuzzLogicFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<FizzBuzzLogicMapperFactory, IFizzBuzzLogicMapperFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<FizzBuzzLogicService, IFizzBuzzLogicService>();
        builder.RegisterTypeInstancePerLifetimeScope<LogicOutputFactory, ILogicOutputFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<LoopEvaluationFactory, ILoopEvaluationFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<LoopLogicService, ILoopLogicService>();
        builder.RegisterTypeInstancePerLifetimeScope<LoopLogicFactory, ILoopLogicFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<LoopLogicFactory, ILoopLogicFactory>();
        builder.RegisterTypeInstancePerLifetimeScope<ModulusCompareService, IModulusCompareService>();
        builder.RegisterTypeInstancePerLifetimeScope<ModulusService, IModulusService>();
        builder.RegisterTypeInstancePerLifetimeScope<ModulusService, IModulusService>();
        builder.RegisterTypeInstancePerLifetimeScope<AndOperator, IAndOperator>();
    }
}