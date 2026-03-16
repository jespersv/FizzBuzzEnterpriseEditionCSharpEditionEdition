using FBEECSEE.Presentation.interfaces;

namespace FBEECSEE.Presentation.impl;

internal class LoopEnumerationFactory : ILoopEnumerationFactory
{
    public IEnumerable<int> CreateLoopEnumeration() => 
        Enumerable.Range(Constants.START_LOOP_VALUE, Constants.MAXIMUM_LOOP_VALUE);
}