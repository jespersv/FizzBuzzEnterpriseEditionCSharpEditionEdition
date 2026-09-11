using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.impl;

internal class FizzBuzzLogicEvaluationFactory : IFizzBuzzLogicEvaluationFactory
{
    private readonly IFizzBuzzLogicFactory _fizzBuzzLogicFactory;

    public FizzBuzzLogicEvaluationFactory(IFizzBuzzLogicFactory fizzBuzzLogicFactory)
    {
        _fizzBuzzLogicFactory = fizzBuzzLogicFactory;
    }

    public bool FizzBuzzEvaluation(int value) => _fizzBuzzLogicFactory.FizzBuzzLogic(value);

    public bool FizzEvaluation(int value) => _fizzBuzzLogicFactory.FizzLogic(value);

    public bool BuzzEvaluation(int value) => _fizzBuzzLogicFactory.BuzzLogic(value);

    public bool TrueEvaluation(int _) => true;
}