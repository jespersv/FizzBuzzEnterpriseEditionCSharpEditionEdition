using FBEECSEE.Library.entities;
using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.impl;

internal class FizzBuzzLogicMapperFactory : IFizzBuzzLogicMapperFactory
{
    private readonly IFizzBuzzLogicFactory _fizzBuzzLogicFactory;
    private readonly ILogicOutputFactory _logicOutputFactory;

    public FizzBuzzLogicMapperFactory(IFizzBuzzLogicFactory fizzBuzzLogicFactory, ILogicOutputFactory logicOutputFactory)
    {
        _fizzBuzzLogicFactory = fizzBuzzLogicFactory;
        _logicOutputFactory = logicOutputFactory;
    }

    public Dictionary<FizzBuzzEnum, EvaluationActionBinding<int>> CreateMapper()
    {
        return new Dictionary<FizzBuzzEnum, EvaluationActionBinding<int>>()
        {
            {FizzBuzzEnum.FizzBuzz, new EvaluationActionBinding<int>(value => _fizzBuzzLogicFactory.FizzBuzzEvalLogic(value), _logicOutputFactory.FizzBuzzOutput)},
            {FizzBuzzEnum.Fizz, new EvaluationActionBinding<int>(value => _fizzBuzzLogicFactory.FizzEvalLogic(value), _logicOutputFactory.FizzOutput)},
            {FizzBuzzEnum.Buzz, new EvaluationActionBinding<int>(value => _fizzBuzzLogicFactory.BuzzEvalLogic(value), _logicOutputFactory.BuzzOutput)},
            {FizzBuzzEnum.NoFizzBuzz, new EvaluationActionBinding<int>(_=> true, _logicOutputFactory.NoFizzBuzzOutput)},
        };
    }
}