using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.entities;

internal record NoFizzBuzzEvaluationActionBinding(IFizzBuzzLogicEvaluationFactory fizzBuzzLogicEvaluationFactory, ILogicOutputFactory logicOutputFactory) :
    EvaluationActionBinding<int>(fizzBuzzLogicEvaluationFactory.TrueEvaluation, logicOutputFactory.NoFizzBuzzOutput)
{
}