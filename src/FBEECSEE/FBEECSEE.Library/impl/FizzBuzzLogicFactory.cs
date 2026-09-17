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

    public bool FizzBuzzLogic(FizzBuzzArrayValue value) => _andOperator.And(FizzLogic(value), BuzzLogic(value));

    public bool FizzLogic(FizzBuzzArrayValue value) => _modulusCompareService.Check(value.value, Constants.FIZZVALUE, Constants.MODULE_FIZZBUZZ_SHOULD_EQUAL);

    public bool BuzzLogic(FizzBuzzArrayValue value) => _modulusCompareService.Check(value.value, Constants.BUZZVALUE, Constants.MODULE_FIZZBUZZ_SHOULD_EQUAL);
}