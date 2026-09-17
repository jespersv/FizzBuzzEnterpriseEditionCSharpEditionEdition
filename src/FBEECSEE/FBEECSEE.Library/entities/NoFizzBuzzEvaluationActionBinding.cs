using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.entities;

internal record NoFizzBuzzEvaluationActionBinding(IFizzBuzzLogicEvaluationFactory fizzBuzzLogicEvaluationFactory, ILogicOutputFactory logicOutputFactory) :
    EvaluationActionBinding<FizzBuzzArrayValue>(fizzBuzzLogicEvaluationFactory.TrueEvaluation, logicOutputFactory.NoFizzBuzzOutput)
{
}