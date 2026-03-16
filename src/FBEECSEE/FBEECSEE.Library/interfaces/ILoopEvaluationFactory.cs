using FBEECSEE.Library.util.functional;

namespace FBEECSEE.Library.interfaces;

internal interface ILoopEvaluationFactory
{
    Func<int, IfTee> Create();
}