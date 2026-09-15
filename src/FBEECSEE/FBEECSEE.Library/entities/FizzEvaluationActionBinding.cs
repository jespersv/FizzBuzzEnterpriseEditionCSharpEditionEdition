using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.entities;

internal record FizzEvaluationActionBinding(IFizzBuzzLogicEvaluationFactory fizzBuzzLogicEvaluationFactory, ILogicOutputFactory logicOutputFactory) :
    EvaluationActionBinding<int>(fizzBuzzLogicEvaluationFactory.FizzEvaluation, logicOutputFactory.FizzOutput)
{
}