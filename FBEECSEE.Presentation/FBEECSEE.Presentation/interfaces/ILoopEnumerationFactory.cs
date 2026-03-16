namespace FBEECSEE.Presentation.interfaces;

internal interface ILoopEnumerationFactory
{
    IEnumerable<int> CreateLoopEnumeration();
}