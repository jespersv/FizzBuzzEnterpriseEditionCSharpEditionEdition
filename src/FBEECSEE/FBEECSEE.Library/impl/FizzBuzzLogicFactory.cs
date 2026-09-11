using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.impl;

internal class FizzBuzzLogicFactory : IFizzBuzzLogicFactory
{
    private readonly IModulusCompareService _modulusCompareService;
    private readonly IAndOperator _andOperator;

    public FizzBuzzLogicFactory(IModulusCompareService modulusCompareService, IAndOperator andOperator)
    {
        _modulusCompareService = modulusCompareService;
        _andOperator = andOperator;
    }

    public bool FizzBuzzLogic(int value) => _andOperator.And(FizzLogic(value), BuzzLogic(value));

    public bool FizzLogic(int value) => _modulusCompareService.Check(value, Constants.FIZZVALUE, Constants.MODULE_FIZZBUZZ_SHOULD_EQUAL);

    public bool BuzzLogic(int value) => _modulusCompareService.Check(value, Constants.BUZZVALUE, Constants.MODULE_FIZZBUZZ_SHOULD_EQUAL);
}