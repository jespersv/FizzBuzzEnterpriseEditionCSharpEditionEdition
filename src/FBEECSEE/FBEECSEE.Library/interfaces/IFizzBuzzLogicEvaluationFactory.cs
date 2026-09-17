namespace FBEECSEE.Library.interfaces;

internal interface IFizzBuzzLogicEvaluationFactory
{
    bool FizzBuzzEvaluation(FizzBuzzArrayValue value);

    bool FizzEvaluation(FizzBuzzArrayValue value);

    bool BuzzEvaluation(FizzBuzzArrayValue value);

    bool TrueEvaluation(FizzBuzzArrayValue _);
}