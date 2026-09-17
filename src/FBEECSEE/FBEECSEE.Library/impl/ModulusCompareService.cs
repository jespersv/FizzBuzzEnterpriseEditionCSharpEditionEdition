namespace FBEECSEE.Library.impl;

internal class ModulusCompareService : IModulusCompareService
{
    private readonly IModulusOperator _modulusOperator;
    private readonly IEquateService _equateService;

    public ModulusCompareService(IModulusOperator modulusOperator, IEquateService equateService)
    {
        _modulusOperator = modulusOperator;
        _equateService = equateService;
    }

    public bool Check(int value, int modulus, int modulusCompareValue)
    {
        var modalResult = _modulusOperator.Eval(value, modulus);
        return _equateService.AreEqual(modalResult, modulusCompareValue);
    }
}