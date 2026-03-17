using Autofac;
using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library;

public class HostService
{
    private readonly IContainer _container;

    public HostService(IContainer container)
    {
        _container = container;
    }

    public static HostService Instance { get; }

    static HostService()
    {
        var builder = new ContainerBuilder();
        builder.RegisterModule<Module>();
        var container = builder.Build();
        Instance = new HostService(container);
    }

    public Task Run()
    {
        var service = _container.Resolve<IFizzBuzzService>();
        service.Run();

        return Task.CompletedTask;
    }
}