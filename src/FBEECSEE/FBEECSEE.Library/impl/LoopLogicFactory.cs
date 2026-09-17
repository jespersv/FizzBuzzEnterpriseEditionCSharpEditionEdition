using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.impl;

internal class LoopLogicFactory : ILoopLogicFactory
{
    private readonly ILoopEvaluationFactory _loopEvaluationFactory;

    public LoopLogicFactory(ILoopEvaluationFactory loopEvaluationFactory)
    {
        _loopEvaluationFactory = loopEvaluationFactory;
    }

    public Func<IEnumerable<FizzBuzzArrayValue>, Task> CreateLoop()
    {
        return loopEnumeration =>
        {
            var func = _loopEvaluationFactory.Create();
            foreach (var loopValue in loopEnumeration)
                func(loopValue).Run();

            return Task.CompletedTask;
        };
    }
}