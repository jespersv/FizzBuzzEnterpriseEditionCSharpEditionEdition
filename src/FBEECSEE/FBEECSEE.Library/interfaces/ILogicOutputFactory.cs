namespace FBEECSEE.Library.interfaces;

internal interface ILogicOutputFactory
{
    void BuzzOutput(FizzBuzzArrayValue value);

    void FizzOutput(FizzBuzzArrayValue value);

    void FizzBuzzOutput(FizzBuzzArrayValue value);

    void NoFizzBuzzOutput(FizzBuzzArrayValue value);
}