namespace FBEECSEE.Library.interfaces;

internal interface IFizzBuzzLogicEvaluationFactory
{
    bool FizzBuzzEvaluation(int value);

    bool FizzEvaluation(int value);

    bool BuzzEvaluation(int value);

    bool TrueEvaluation(int _);
}