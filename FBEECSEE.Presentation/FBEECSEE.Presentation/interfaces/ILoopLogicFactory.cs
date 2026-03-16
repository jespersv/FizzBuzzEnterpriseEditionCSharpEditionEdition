namespace FBEECSEE.Presentation.interfaces;

internal interface ILoopLogicFactory
{
    Func<IEnumerable<int>, Task> CreateLoop();
}