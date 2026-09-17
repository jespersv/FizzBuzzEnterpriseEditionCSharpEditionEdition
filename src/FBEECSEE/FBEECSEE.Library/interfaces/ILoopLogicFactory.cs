namespace FBEECSEE.Library.interfaces;

internal interface ILoopLogicFactory
{
    Func<FizzBuzzCollection, Task> CreateLoop();
}