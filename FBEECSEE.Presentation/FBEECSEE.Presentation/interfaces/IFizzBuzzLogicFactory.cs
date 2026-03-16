namespace FBEECSEE.Presentation.interfaces;

internal interface IFizzBuzzLogicFactory
{
    bool FizzBuzzEvalLogic(int value);

    bool FizzEvalLogic(int value);

    bool BuzzEvalLogic(int value);
}