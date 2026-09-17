namespace FBEECSEE.Library.interfaces;

internal interface ILoopLogicFactory
{
    Func<IEnumerable<FizzBuzzArrayValue>, Task> CreateLoop();
}