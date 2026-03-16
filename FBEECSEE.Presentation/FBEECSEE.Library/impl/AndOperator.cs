using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.impl;

internal class AndOperator : IAndOperator
{
    public bool And(bool v1, bool v2) => v1 && v2;
}