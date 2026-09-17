using Autofac;

namespace FBEECSEE.Library;

public class HostService
{
    private static readonly IFizzBuzzService Service;

    public static HostService Instance { get; }

    static HostService()
    {
        var builder = new ContainerBuilder();
        builder.RegisterModule<Module>();
        var container = builder.Build();
        Service = container.Resolve<IFizzBuzzService>();
        Instance = new HostService();
    }

    public Task Run()
    {
        Service.Run();

        return Task.CompletedTask;
    }
}