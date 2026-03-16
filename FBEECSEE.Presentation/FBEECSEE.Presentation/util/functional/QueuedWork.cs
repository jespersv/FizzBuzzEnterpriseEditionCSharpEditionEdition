namespace FBEECSEE.Presentation.util.Functional;

internal class QueuedWork<TWork>
{
    internal readonly Func<bool> _condition;
    internal readonly TWork _work;

    internal QueuedWork(Func<bool> condition, TWork work)
    {
        _condition = condition;
        _work = work;
    }
}