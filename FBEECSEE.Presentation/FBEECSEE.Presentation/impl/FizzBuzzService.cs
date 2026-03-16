using FBEECSEE.Presentation.interfaces;

namespace FBEECSEE.Presentation.impl;

internal class FizzBuzzService : IFizzBuzzService
{
    private readonly ILoopEnumerationFactory _loopEnumerationFactory;
    private readonly ILoopLogicService _loopLogicService;

    public FizzBuzzService(ILoopEnumerationFactory loopEnumerationFactory, ILoopLogicService loopLogicService)
    {
        _loopEnumerationFactory = loopEnumerationFactory;
        _loopLogicService = loopLogicService;
    }

    public Task Run()
    {
        var loopEnumeration = _loopEnumerationFactory.CreateLoopEnumeration();
        _loopLogicService.RunLoop(loopEnumeration);

        return Task.CompletedTask;
    }
}