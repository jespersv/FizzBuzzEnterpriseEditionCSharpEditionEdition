using Autofac;

namespace FBEECSEE.Presentation.util;

public static class ContainerBuilderExtensions
{
    public static void RegisterTypeInstancePerLifetimeScope<TImplementation, TInterface>(this ContainerBuilder builder) 
        where TImplementation : notnull where TInterface : notnull
    {
        builder.RegisterType<TImplementation>().As<TInterface>().InstancePerLifetimeScope();
    }
}