namespace FBEECSEE.Library.interfaces;

internal interface IFizzBuzzLogicFactory
{
    bool FizzBuzzLogic(FizzBuzzArrayValue value);

    bool FizzLogic(FizzBuzzArrayValue value);

    bool BuzzLogic(FizzBuzzArrayValue value);
}