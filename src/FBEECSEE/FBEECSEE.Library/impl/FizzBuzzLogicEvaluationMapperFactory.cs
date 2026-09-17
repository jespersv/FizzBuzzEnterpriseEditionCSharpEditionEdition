namespace FBEECSEE.Library.impl;

internal class FizzBuzzLogicEvaluationMapperFactory : IFizzBuzzLogicEvaluationMapperFactory
{
    private readonly IFizzBuzzLogicEvaluationMapFactory _fizzBuzzLogicEvaluationMapFactory;

    public FizzBuzzLogicEvaluationMapperFactory(IFizzBuzzLogicEvaluationMapFactory fizzBuzzLogicEvaluationMapFactory)
    {
        _fizzBuzzLogicEvaluationMapFactory = fizzBuzzLogicEvaluationMapFactory;
    }

    public Dictionary<FizzBuzzEnum, EvaluationActionBinding<FizzBuzzArrayValue>> CreateMapper()
    {
        var fizzBuzzLogicMap = _fizzBuzzLogicEvaluationMapFactory.CreateFizzBuzzLogicMap();
        var buzzLogicMap = _fizzBuzzLogicEvaluationMapFactory.CreateBuzzLogicMap();
        var fizzLogicMap = _fizzBuzzLogicEvaluationMapFactory.CreateFizzLogicMap();
        var noFizzBuzzLogicMap = _fizzBuzzLogicEvaluationMapFactory.CreateNoFizzBuzzLogicMap();

        var dict = new Dictionary<FizzBuzzEnum, EvaluationActionBinding<FizzBuzzArrayValue>>
        {
            { fizzBuzzLogicMap.Key, fizzBuzzLogicMap.Value },
            { buzzLogicMap.Key, buzzLogicMap.Value },
            { fizzLogicMap.Key, fizzLogicMap.Value },
            { noFizzBuzzLogicMap.Key, noFizzBuzzLogicMap.Value },
        };

        return dict;
    }
}
