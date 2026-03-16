namespace FBEECSEE.Library.interfaces;

internal interface IFizzBuzzLogicFactory
{
    bool FizzBuzzEvalLogic(int value);

    bool FizzEvalLogic(int value);

    bool BuzzEvalLogic(int value);
}