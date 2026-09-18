using FBEECSEE.Library.util.functional;

namespace FBEECSEE.Library.interfaces;

internal interface ILogicEvaluationFactory
{
    Func<FizzBuzzArrayValue, IfTee> Create();
}