namespace FBEECSEE.Library.impl;

internal class FizzBuzzLogicProvider : IFizzBuzzLogicProvider
{
    private readonly Dictionary<FizzBuzzEnum, EvaluationActionBinding<FizzBuzzArrayValue>> _logicMapperFactory;

    public FizzBuzzLogicProvider(IFizzBuzzLogicEvaluationMapperFactory logicEvaluationMapperFactory)
    {
        _logicMapperFactory = logicEvaluationMapperFactory.CreateMapper();
    }

    public Func<bool> GetEval(FizzBuzzEnum en, FizzBuzzArrayValue value) => () => _logicMapperFactory[en].eval(value);

    public Action GetResult(FizzBuzzEnum en) => () => _logicMapperFactory[en].result(default);

    public Action GetResult(FizzBuzzEnum en, FizzBuzzArrayValue value) => () => _logicMapperFactory[en].result(value);
}