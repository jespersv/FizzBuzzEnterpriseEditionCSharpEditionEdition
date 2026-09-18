namespace FBEECSEE.Library.impl;

internal class LoopLogicFactory : ILoopLogicFactory
{
    private readonly ILogicEvaluationFactory _logicEvaluationFactory;

    public LoopLogicFactory(ILogicEvaluationFactory logicEvaluationFactory)
    {
        _logicEvaluationFactory = logicEvaluationFactory;
    }

    public Func<FizzBuzzCollection, Task> CreateLoop()
    {
        return loopEnumeration =>
        {
            var func = _logicEvaluationFactory.Create();
            foreach (var loopValue in loopEnumeration)
                func(loopValue).Run();

            return Task.CompletedTask;
        };
    }
}