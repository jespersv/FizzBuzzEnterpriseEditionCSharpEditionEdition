namespace FBEECSEE.Presentation.util.Functional;

public abstract class IfBase<TWork>
{
    internal readonly Queue<QueuedWork<TWork>> _cases;
    internal TWork _defaultBehavior;

    internal IfBase(Queue<QueuedWork<TWork>> cases, TWork defaultBehavior)
    {
        if (cases.Count <= 0) throw new ArgumentException("Need at minimum one if.");
        _cases = new Queue<QueuedWork<TWork>>(cases);
        _defaultBehavior = defaultBehavior;
    }
}