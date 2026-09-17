using FBEECSEE.Library.impl;
using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.entities;

internal record BuzzEvaluationActionBinding(IFizzBuzzLogicEvaluationFactory fizzBuzzLogicEvaluationFactory, ILogicOutputFactory logicOutputFactory) :
    EvaluationActionBinding<FizzBuzzArrayValue>(fizzBuzzLogicEvaluationFactory.BuzzEvaluation, logicOutputFactory.BuzzOutput)
{
}