using FBEECSEE.Presentation.interfaces;

namespace FBEECSEE.Presentation.impl;

internal class ModulusCompareService : IModulusCompareService
{
    private readonly IModulusService _modulusService;
    private readonly IEquateService _equateService;

    public ModulusCompareService(IModulusService modulusService, IEquateService equateService)
    {
        _modulusService = modulusService;
        _equateService = equateService;
    }

    public bool Check(int value, int fizzbuzzValue, int modulusCompareValue)
    {
        var modalResult = _modulusService.Eval(value, fizzbuzzValue);
        return _equateService.AreEqual(modalResult, Constants.MODULE_FIZZBUZZ_SHOULD_EQUAL);
    }
}