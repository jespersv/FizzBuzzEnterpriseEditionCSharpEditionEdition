namespace FBEECSEE.Presentation.interfaces;

internal interface ILogicOutputFactory
{
    void BuzzOutput(int value);

    void FizzOutput(int value);

    void FizzBuzzOutput(int value);

    void NoFizzBuzzOutput(int value);
}