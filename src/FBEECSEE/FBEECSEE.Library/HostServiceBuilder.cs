using Autofac;
using Autofac.Core;

namespace FBEECSEE.Library;

public static class HostServiceBuilder
{
    public static HostService Build()
    {
        return new ContainerBuilder().RegisterModule<Module>().Build().Resolve<IFizzBuzzService>().ToHostService();
    }

    internal static HostService ToHostService(this IFizzBuzzService service)
    {
        return new HostService(service);
    }

}

public static class ContainerBuilderExtensions
{
    public static ContainerBuilder RegisterModule<TModule>(this ContainerBuilder builder) where TModule : IModule, new()
    {
        ModuleRegistrationExtensions.RegisterModule<TModule>(builder);
        return builder;
    }
}