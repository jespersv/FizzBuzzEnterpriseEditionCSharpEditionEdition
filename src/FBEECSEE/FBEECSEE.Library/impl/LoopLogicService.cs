namespace FBEECSEE.Library.impl;

internal class LoopLogicService : ILoopLogicService
{
    private readonly ILoopLogicFactory _loopLogicFactory;

    public LoopLogicService(ILoopLogicFactory loopLogicFactory)
    {
        _loopLogicFactory = loopLogicFactory;
    }

    public void RunLoop(FizzBuzzCollection loopEnumeration)
    {
        var loopLogic = _loopLogicFactory.CreateLoop();
        loopLogic(loopEnumeration);
    }
}