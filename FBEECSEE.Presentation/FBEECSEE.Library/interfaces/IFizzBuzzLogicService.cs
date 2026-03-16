using FBEECSEE.Library.impl;

namespace FBEECSEE.Library.interfaces;

internal interface IFizzBuzzLogicService
{
    Func<bool> GetEval(FizzBuzzEnum en, int value);

    Action GetResult(FizzBuzzEnum en);

    Action GetResult(FizzBuzzEnum noFizzBuzz, int value);
}