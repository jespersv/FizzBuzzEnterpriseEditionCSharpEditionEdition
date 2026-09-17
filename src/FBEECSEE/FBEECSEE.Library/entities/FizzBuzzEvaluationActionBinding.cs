using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.entities;

internal record FizzBuzzEvaluationActionBinding(IFizzBuzzLogicEvaluationFactory fizzBuzzLogicEvaluationFactory, ILogicOutputFactory logicOutputFactory) :
    EvaluationActionBinding<FizzBuzzArrayValue>(fizzBuzzLogicEvaluationFactory.FizzBuzzEvaluation, logicOutputFactory.FizzBuzzOutput)
{
}