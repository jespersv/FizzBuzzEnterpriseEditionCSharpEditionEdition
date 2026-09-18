namespace FBEECSEE.Library;

public class HostService
{
    private readonly IFizzBuzzService _service;

    public HostService(IFizzBuzzService service)
    {
        _service = service;
    }
    
    public Task Run()
    {
        _service.Run();

        return Task.CompletedTask;
    }
}