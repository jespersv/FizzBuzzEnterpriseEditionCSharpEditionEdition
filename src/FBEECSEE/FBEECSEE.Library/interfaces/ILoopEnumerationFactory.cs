namespace FBEECSEE.Library.interfaces;

internal interface ILoopEnumerationFactory
{
    IEnumerable<int> CreateLoopEnumeration();
}