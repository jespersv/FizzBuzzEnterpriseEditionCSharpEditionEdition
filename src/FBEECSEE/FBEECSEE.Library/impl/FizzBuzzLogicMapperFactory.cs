using FBEECSEE.Library.entities;
using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.impl;

internal class FizzBuzzLogicMapperFactory : IFizzBuzzLogicMapperFactory
{
    private readonly IFizzBuzzLogicMapFactory _fizzBuzzLogicMapFactory;

    public FizzBuzzLogicMapperFactory(IFizzBuzzLogicMapFactory fizzBuzzLogicMapFactory)
    {
        _fizzBuzzLogicMapFactory = fizzBuzzLogicMapFactory;
    }

    public Dictionary<FizzBuzzEnum, EvaluationActionBinding<int>> CreateMapper()
    {
        var fizzBuzzLogicMap = _fizzBuzzLogicMapFactory.CreateFizzBuzzLogicMap();
        var buzzLogicMap = _fizzBuzzLogicMapFactory.CreateBuzzLogicMap();
        var fizzLogicMap = _fizzBuzzLogicMapFactory.CreateFizzLogicMap();
        var noFizzBuzzLogicMap = _fizzBuzzLogicMapFactory.CreateNoFizzBuzzLogicMap();

        var dict = new Dictionary<FizzBuzzEnum, EvaluationActionBinding<int>>
        {
            { fizzBuzzLogicMap.Key, fizzBuzzLogicMap.Value },
            { buzzLogicMap.Key, buzzLogicMap.Value },
            { fizzLogicMap.Key, fizzLogicMap.Value },
            { noFizzBuzzLogicMap.Key, noFizzBuzzLogicMap.Value },
        };

        return dict;
    }
}
