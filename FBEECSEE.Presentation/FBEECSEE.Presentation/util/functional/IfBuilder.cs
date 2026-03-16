namespace FBEECSEE.Presentation.util.Functional;

public abstract class IfBuilder<TWork>
{
    internal readonly Queue<QueuedWork<TWork>> _cases;
    internal TWork _elseBehavior;

    protected internal IfBuilder()
    {
        _cases = new Queue<QueuedWork<TWork>>();
    }

    internal IfBuilder<TWork> AddIf(Func<bool> caseVal, TWork fn)
    {
        if (_cases.Count > 0) throw new ArgumentException($"Cannot add more than one case through if.");
        return AddElseIf(caseVal, fn, true);
    }

    internal IfBuilder<TWork> AddElseIf(Func<bool> caseVal, TWork fn, bool isFirst = false)
    {
        if (!isFirst && _cases.Count <= 0) throw new ArgumentException("Cannot add elseif before if.");
        if (_elseBehavior != null) throw new ArgumentException($"Cannot add elseif after else.");
        if (fn == null) throw new ArgumentNullException(nameof(fn));
        _cases.Enqueue(new QueuedWork<TWork>(caseVal, fn));
        return this;
    }

    internal IfBuilder<TWork> AddElse(TWork fn)
    {
        if (_cases.Count <= 0) throw new ArgumentException($"Cannot add else behavior before normal behaviors.");
        if (_elseBehavior != null) throw new ArgumentException($"Default behavior already defined.");
        _elseBehavior = fn ?? throw new ArgumentNullException(nameof(fn));
        return this;
    }
}