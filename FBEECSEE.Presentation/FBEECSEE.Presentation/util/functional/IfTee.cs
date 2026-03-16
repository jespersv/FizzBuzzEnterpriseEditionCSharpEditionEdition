namespace FBEECSEE.Presentation.util.Functional;

public sealed class IfTee : IfBase<Action>
{
    internal IfTee(Queue<QueuedWork<Action>> cases, Action defaultBehavior) : base(cases, defaultBehavior)
    {
    }

    public void Run()
    {
        if (_cases.Count == 0) throw new ArgumentException($"Does not contain any conditions. Already ran?");

        while (_cases.Count > 0)
        {
            var c = _cases.Dequeue();
            if (!c._condition()) continue;
                
            c._work();
            return;
        }

        if (_defaultBehavior != null) _defaultBehavior();
    }
}