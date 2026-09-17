using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.impl;

internal class FizzBuzzLogicEvaluationFactory : IFizzBuzzLogicEvaluationFactory
{
    private readonly IFizzBuzzLogicFactory _fizzBuzzLogicFactory;

    public FizzBuzzLogicEvaluationFactory(IFizzBuzzLogicFactory fizzBuzzLogicFactory)
    {
        _fizzBuzzLogicFactory = fizzBuzzLogicFactory;
    }

    public bool FizzBuzzEvaluation(FizzBuzzArrayValue value) => _fizzBuzzLogicFactory.FizzBuzzLogic(value);

    public bool FizzEvaluation(FizzBuzzArrayValue value) => _fizzBuzzLogicFactory.FizzLogic(value);

    public bool BuzzEvaluation(FizzBuzzArrayValue value) => _fizzBuzzLogicFactory.BuzzLogic(value);

    public bool TrueEvaluation(FizzBuzzArrayValue _) => true;
}