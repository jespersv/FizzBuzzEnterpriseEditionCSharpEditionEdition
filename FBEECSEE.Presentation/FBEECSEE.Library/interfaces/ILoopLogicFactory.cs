namespace FBEECSEE.Library.interfaces;

internal interface ILoopLogicFactory
{
    Func<IEnumerable<int>, Task> CreateLoop();
}