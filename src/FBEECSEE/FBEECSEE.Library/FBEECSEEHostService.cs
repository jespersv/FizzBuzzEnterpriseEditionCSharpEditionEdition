using Autofac;
using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library;

public class FBEECSEEHostService
{
    private readonly IContainer _container;

    public FBEECSEEHostService(IContainer container)
    {
        _container = container;
    }

    public static FBEECSEEHostService Instance { get; }

    static FBEECSEEHostService()
    {
        var builder = new ContainerBuilder();
        builder.RegisterModule<FizzBuzzModule>();
        var container = builder.Build();
        Instance = new FBEECSEEHostService(container);
    }

    public Task Run()
    {
        var service = _container.Resolve<IFizzBuzzService>();
        service.Run();

        return Task.CompletedTask;
    }
}