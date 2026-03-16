using FBEECSEE.Presentation.interfaces;

namespace FBEECSEE.Presentation.impl;

internal class LoopLogicService : ILoopLogicService
{
    private readonly ILoopLogicFactory _loopLogicFactory;

    public LoopLogicService(ILoopLogicFactory loopLogicFactory)
    {
        _loopLogicFactory = loopLogicFactory;
    }

    public void RunLoop(IEnumerable<int> loopEnumeration)
    {
        var loopLogic = _loopLogicFactory.CreateLoop();
        loopLogic(loopEnumeration);
    }
}