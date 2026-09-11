namespace FBEECSEE.Library.interfaces;

internal interface IFizzBuzzLogicFactory
{
    bool FizzBuzzLogic(int value);

    bool FizzLogic(int value);

    bool BuzzLogic(int value);
}