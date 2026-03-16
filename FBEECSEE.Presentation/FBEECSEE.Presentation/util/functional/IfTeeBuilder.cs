namespace FBEECSEE.Presentation.util.Functional;

public sealed class IfTeeBuilder : IfBuilder<Action>
{
    internal IfTee Build() => new IfTee(_cases, _elseBehavior);
}