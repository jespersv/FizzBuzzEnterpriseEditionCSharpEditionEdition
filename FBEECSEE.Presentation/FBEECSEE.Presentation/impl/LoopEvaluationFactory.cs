using FBEECSEE.Presentation.interfaces;
using FBEECSEE.Presentation.util.Functional;

namespace FBEECSEE.Presentation.impl;

internal class LoopEvaluationFactory : ILoopEvaluationFactory
{
    private readonly IFizzBuzzLogicService _logicMap;

    public LoopEvaluationFactory(IFizzBuzzLogicService logicMap)
    {
        _logicMap = logicMap;
    }

    public Func<int, IfTee> Create()
    {
        return value => If.Tee()
            .If(_logicMap.GetEval(FizzBuzzEnum.FizzBuzz, value), _logicMap.GetResult(FizzBuzzEnum.FizzBuzz))
            .ElseIf(_logicMap.GetEval(FizzBuzzEnum.Fizz, value), _logicMap.GetResult(FizzBuzzEnum.Fizz))
            .ElseIf(_logicMap.GetEval(FizzBuzzEnum.Buzz, value), _logicMap.GetResult(FizzBuzzEnum.Buzz))
            .Else(_logicMap.GetResult(FizzBuzzEnum.NoFizzBuzz, value))
            .Build();
    }
}

