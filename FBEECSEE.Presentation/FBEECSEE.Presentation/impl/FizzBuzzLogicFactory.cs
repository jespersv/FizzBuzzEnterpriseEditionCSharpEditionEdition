using FBEECSEE.Presentation.interfaces;

namespace FBEECSEE.Presentation.impl;

internal class FizzBuzzLogicFactory : IFizzBuzzLogicFactory
{
    private readonly IModulusCompareService _modulusCompareService;
    private readonly IAndOperator _andOperator;

    public FizzBuzzLogicFactory(IModulusCompareService modulusCompareService, IAndOperator andOperator)
    {
        _modulusCompareService = modulusCompareService;
        _andOperator = andOperator;
    }

    public bool FizzBuzzEvalLogic(int value) => _andOperator.And(FizzEvalLogic(value), BuzzEvalLogic(value));

    public bool FizzEvalLogic(int value) => _modulusCompareService.Check(value, Constants.FIZZVALUE, Constants.MODULE_FIZZBUZZ_SHOULD_EQUAL);

    public bool BuzzEvalLogic(int value) => _modulusCompareService.Check(value, Constants.BUZZVALUE, Constants.MODULE_FIZZBUZZ_SHOULD_EQUAL);
}