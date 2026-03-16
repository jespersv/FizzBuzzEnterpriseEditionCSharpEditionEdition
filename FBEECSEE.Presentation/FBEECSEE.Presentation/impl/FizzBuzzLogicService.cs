using FBEECSEE.Presentation.entities;
using FBEECSEE.Presentation.interfaces;

namespace FBEECSEE.Presentation.impl;

internal class FizzBuzzLogicService : IFizzBuzzLogicService
{
    private readonly Dictionary<FizzBuzzEnum, EvaluationActionBinding<int>> _logicMapperFactory;

    public FizzBuzzLogicService(IFizzBuzzLogicMapperFactory logicMapperFactory)
    {
        _logicMapperFactory = logicMapperFactory.CreateMapper();
    }

    public Func<bool> GetEval(FizzBuzzEnum en, int value)
    {
        return () => _logicMapperFactory[en].eval(value);
    }

    public Action GetResult(FizzBuzzEnum en)
    {
        return () => _logicMapperFactory[en].result(default);
    }

    public Action GetResult(FizzBuzzEnum en, int value)
    {
        return () => _logicMapperFactory[en].result(value);
    }
}