using FBEECSEE.Library.entities;
using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.impl;

internal class FizzBuzzLogicEvaluationMapFactory : IFizzBuzzLogicEvaluationMapFactory
{
    private readonly IFizzBuzzLogicEvaluationFactory _fizzBuzzLogicEvaluationFactory;
    private readonly ILogicOutputFactory _logicOutputFactory;

    public FizzBuzzLogicEvaluationMapFactory(IFizzBuzzLogicEvaluationFactory fizzBuzzLogicEvaluationFactory, ILogicOutputFactory logicOutputFactory)
    {
        _fizzBuzzLogicEvaluationFactory = fizzBuzzLogicEvaluationFactory;
        _logicOutputFactory = logicOutputFactory;
    }


    public FizzBuzzLogicMap CreateFizzBuzzLogicMap()
    {
        return new FizzBuzzLogicMap(FizzBuzzEnum.FizzBuzz, new FizzBuzzEvaluationActionBinding(_fizzBuzzLogicEvaluationFactory, _logicOutputFactory));
    }
    public FizzBuzzLogicMap CreateBuzzLogicMap()
    {
        return new FizzBuzzLogicMap(FizzBuzzEnum.Fizz, new FizzEvaluationActionBinding(_fizzBuzzLogicEvaluationFactory, _logicOutputFactory));
    }
    public FizzBuzzLogicMap CreateFizzLogicMap()
    {
        return new FizzBuzzLogicMap(FizzBuzzEnum.Buzz, new BuzzEvaluationActionBinding(_fizzBuzzLogicEvaluationFactory, _logicOutputFactory));
    }
    public FizzBuzzLogicMap CreateNoFizzBuzzLogicMap()
    {
        return new FizzBuzzLogicMap(FizzBuzzEnum.NoFizzBuzz, new NoFizzBuzzEvaluationActionBinding(_fizzBuzzLogicEvaluationFactory, _logicOutputFactory));
    }
}