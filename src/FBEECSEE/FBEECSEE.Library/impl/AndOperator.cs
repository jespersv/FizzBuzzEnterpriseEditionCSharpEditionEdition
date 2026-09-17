namespace FBEECSEE.Library.impl;

internal sealed class AndOperator : IAndOperator
{
    public bool And(bool v1, bool v2) => v1 && v2;
}