using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.entities;

internal record FizzBuzzEvaluationActionBinding(IFizzBuzzLogicEvaluationFactory fizzBuzzLogicEvaluationFactory, ILogicOutputFactory logicOutputFactory) :
    EvaluationActionBinding<int>(fizzBuzzLogicEvaluationFactory.FizzBuzzEvaluation, logicOutputFactory.FizzBuzzOutput)
{
}