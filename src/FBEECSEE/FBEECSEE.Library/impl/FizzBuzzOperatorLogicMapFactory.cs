using FBEECSEE.Library.entities;
using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.impl;

internal class FizzBuzzOperatorLogicMapFactory : IFizzBuzzOperatorLogicMapFactory
{
    private readonly IFizzBuzzLogicProvider _logicMap;

    public FizzBuzzOperatorLogicMapFactory(IFizzBuzzLogicProvider logicMap)
    {
        _logicMap = logicMap;
    }

    public FizzBuzzOperatorLogicMap GetFizzBuzz() =>
        new(value => _logicMap.GetEval(FizzBuzzEnum.FizzBuzz, value), _ => _logicMap.GetResult(FizzBuzzEnum.FizzBuzz));

    public FizzBuzzOperatorLogicMap GetFizz() =>
        new(value => _logicMap.GetEval(FizzBuzzEnum.Fizz, value), _ => _logicMap.GetResult(FizzBuzzEnum.Fizz));

    public FizzBuzzOperatorLogicMap GetBuzz() =>
        new(value => _logicMap.GetEval(FizzBuzzEnum.Buzz, value), _ => _logicMap.GetResult(FizzBuzzEnum.Buzz));

    public FizzBuzzOperatorLogicMap GetNoFizzBuzz() =>
        new(value => _logicMap.GetEval(FizzBuzzEnum.NoFizzBuzz, value), value => _logicMap.GetResult(FizzBuzzEnum.NoFizzBuzz, value));
}