namespace FBEECSEE.Library.interfaces;

internal interface ILoopEnumerationFactory
{
    IEnumerable<FizzBuzzArrayValue> CreateLoopEnumeration();
}