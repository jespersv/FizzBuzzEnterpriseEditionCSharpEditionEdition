using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.entities;

internal record FizzEvaluationActionBinding(IFizzBuzzLogicEvaluationFactory fizzBuzzLogicEvaluationFactory, ILogicOutputFactory logicOutputFactory) :
    EvaluationActionBinding<FizzBuzzArrayValue>(fizzBuzzLogicEvaluationFactory.FizzEvaluation, logicOutputFactory.FizzOutput)
{
}