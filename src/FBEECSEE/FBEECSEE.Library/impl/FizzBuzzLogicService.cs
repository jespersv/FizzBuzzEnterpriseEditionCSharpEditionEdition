using FBEECSEE.Library.entities;
using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.impl;

internal class FizzBuzzLogicService : IFizzBuzzLogicService
{
    private readonly Dictionary<FizzBuzzEnum, EvaluationActionBinding<int>> _logicMapperFactory;

    public FizzBuzzLogicService(IFizzBuzzLogicMapperFactory logicMapperFactory)
    {
        _logicMapperFactory = logicMapperFactory.CreateMapper();
    }

    public Func<bool> GetEval(FizzBuzzEnum en, int value) => () => _logicMapperFactory[en].eval(value);

    public Action GetResult(FizzBuzzEnum en) => () => _logicMapperFactory[en].result(default);

    public Action GetResult(FizzBuzzEnum en, int value) => () => _logicMapperFactory[en].result(value);
}