using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.entities;

internal record BuzzEvaluationActionBinding(IFizzBuzzLogicEvaluationFactory fizzBuzzLogicEvaluationFactory, ILogicOutputFactory logicOutputFactory) :
    EvaluationActionBinding<int>(fizzBuzzLogicEvaluationFactory.BuzzEvaluation, logicOutputFactory.BuzzOutput)
{
}