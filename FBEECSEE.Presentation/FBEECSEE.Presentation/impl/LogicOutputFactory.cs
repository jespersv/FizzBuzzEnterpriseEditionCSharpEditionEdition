using FBEECSEE.Presentation.interfaces;

namespace FBEECSEE.Presentation.impl;

internal class LogicOutputFactory : ILogicOutputFactory
{
    private readonly IDisplayService _displayService;

    public LogicOutputFactory(IDisplayService displayService)
    {
        _displayService = displayService;
    }

    public void BuzzOutput(int value) => _displayService.Show(Constants.BUZZ_STR);

    public void FizzOutput(int value) => _displayService.Show(Constants.FIZZ_STR);

    public void FizzBuzzOutput(int value) => _displayService.Show(Constants.FIZZBUZZ_STR);

    public void NoFizzBuzzOutput(int value) => _displayService.Show(value.ToString());
}