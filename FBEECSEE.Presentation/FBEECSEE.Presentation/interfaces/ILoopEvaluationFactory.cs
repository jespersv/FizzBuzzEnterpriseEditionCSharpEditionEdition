using FBEECSEE.Presentation.util.Functional;

namespace FBEECSEE.Presentation.interfaces;

internal interface ILoopEvaluationFactory
{
    Func<int, IfTee> Create();
}