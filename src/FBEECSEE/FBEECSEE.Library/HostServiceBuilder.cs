namespace FBEECSEE.Library;

public static class HostServiceBuilder
{
    public static HostService Build() => 
        new Autofac.ContainerBuilder()
            .RegisterModule<Module>()
            .Build()
            .Resolve<IFizzBuzzService>()
            .ToHostService();

    internal static HostService ToHostService(this IFizzBuzzService service) => new(service);
}