using FBEECSEE.Library.impl;

namespace FBEECSEE.Library.interfaces;

internal interface IFizzBuzzLogicProvider
{
    Func<bool> GetEval(FizzBuzzEnum en, FizzBuzzArrayValue value);

    Action GetResult(FizzBuzzEnum en);

    Action GetResult(FizzBuzzEnum noFizzBuzz, FizzBuzzArrayValue value);
}