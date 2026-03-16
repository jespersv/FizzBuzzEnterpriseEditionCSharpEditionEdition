namespace FBEECSEE.Library.util.functional;

public sealed class IfTeeBuilder : IfBuilder<Action>
{
    internal IfTee Build() => new IfTee(_cases, _elseBehavior);
}