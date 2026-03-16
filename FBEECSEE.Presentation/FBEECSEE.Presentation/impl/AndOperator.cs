using FBEECSEE.Presentation.interfaces;

namespace FBEECSEE.Presentation.impl;

internal class AndOperator : IAndOperator
{
    public bool And(bool v1, bool v2) => v1 && v2;
}