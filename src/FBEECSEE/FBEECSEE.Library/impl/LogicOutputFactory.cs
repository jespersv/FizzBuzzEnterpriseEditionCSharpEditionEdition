namespace FBEECSEE.Library.impl;

internal class LogicOutputFactory : ILogicOutputFactory
{
    private readonly IDisplayService _displayService;

    public LogicOutputFactory(IDisplayService displayService)
    {
        _displayService = displayService;
    }

    public void BuzzOutput(FizzBuzzArrayValue _) => _displayService.Show(Constants.BUZZ_STR);

    public void FizzOutput(FizzBuzzArrayValue _) => _displayService.Show(Constants.FIZZ_STR);

    public void FizzBuzzOutput(FizzBuzzArrayValue _) => _displayService.Show(Constants.FIZZBUZZ_STR);

    public void NoFizzBuzzOutput(FizzBuzzArrayValue value) => _displayService.Show(value.value.ToString());
}