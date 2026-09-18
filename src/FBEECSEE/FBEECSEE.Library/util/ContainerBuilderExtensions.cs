using Autofac;
using Autofac.Core;

namespace FBEECSEE.Library.util;

public static class ContainerBuilderExtensions
{
    public static void RegisterTypeInstancePerLifetimeScope<TImplementation, TInterface>(this ContainerBuilder builder)
        where TImplementation : notnull where TInterface : notnull
    {
        builder.RegisterType<TImplementation>().As<TInterface>().InstancePerLifetimeScope();
    }

    public static ContainerBuilder RegisterModule<TModule>(this ContainerBuilder builder) where TModule : IModule, new()
    {
        ModuleRegistrationExtensions.RegisterModule<TModule>(builder);
        return builder;
    }

    public static TService Resolve<TService>(this IComponentContext context)
        where TService : notnull => ResolutionExtensions.Resolve<TService>(context);
}