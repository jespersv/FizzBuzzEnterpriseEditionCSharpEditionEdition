using FBEECSEE.Library.impl;

namespace FBEECSEE.Library.interfaces;

internal interface ILoopLogicService
{
    void RunLoop(IEnumerable<FizzBuzzArrayValue> loopEnumeration);
}