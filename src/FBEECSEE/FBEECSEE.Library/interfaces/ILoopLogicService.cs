namespace FBEECSEE.Library.interfaces;

internal interface ILoopLogicService
{
    void RunLoop(IEnumerable<int> loopEnumeration);
}