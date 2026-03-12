using Autofac;

public class FizzBuzzModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<FizzBuzzService>().As<IFizzBuzzService>();
    }
}