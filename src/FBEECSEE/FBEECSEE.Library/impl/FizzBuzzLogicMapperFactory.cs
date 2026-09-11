using FBEECSEE.Library.entities;
using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.impl;

internal class FizzBuzzLogicMapperFactory : IFizzBuzzLogicMapperFactory
{
    private readonly IFizzBuzzLogicEvaluationFactory _fizzBuzzLogicEvaluationFactory;
    private readonly ILogicOutputFactory _logicOutputFactory;

    public FizzBuzzLogicMapperFactory(IFizzBuzzLogicEvaluationFactory fizzBuzzLogicEvaluationFactory, ILogicOutputFactory logicOutputFactory)
    {
        _fizzBuzzLogicEvaluationFactory = fizzBuzzLogicEvaluationFactory;
        _logicOutputFactory = logicOutputFactory;
    }

    public Dictionary<FizzBuzzEnum, EvaluationActionBinding<int>> CreateMapper()
    {
        return new Dictionary<FizzBuzzEnum, EvaluationActionBinding<int>>()
        {
            {FizzBuzzEnum.FizzBuzz, new EvaluationActionBinding<int>(_fizzBuzzLogicEvaluationFactory.FizzBuzzEvaluation, _logicOutputFactory.FizzBuzzOutput)},
            {FizzBuzzEnum.Fizz, new EvaluationActionBinding<int>(_fizzBuzzLogicEvaluationFactory.FizzEvaluation, _logicOutputFactory.FizzOutput)},
            {FizzBuzzEnum.Buzz, new EvaluationActionBinding<int>(_fizzBuzzLogicEvaluationFactory.BuzzEvaluation, _logicOutputFactory.BuzzOutput)},
            {FizzBuzzEnum.NoFizzBuzz, new EvaluationActionBinding<int>(_fizzBuzzLogicEvaluationFactory.TrueEvaluation, _logicOutputFactory.NoFizzBuzzOutput)},
        };
    }
}