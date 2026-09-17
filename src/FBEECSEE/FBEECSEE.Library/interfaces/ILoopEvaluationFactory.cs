using FBEECSEE.Library.impl;
using FBEECSEE.Library.util.functional;

namespace FBEECSEE.Library.interfaces;

internal interface ILoopEvaluationFactory
{
    Func<FizzBuzzArrayValue, IfTee> Create();
}