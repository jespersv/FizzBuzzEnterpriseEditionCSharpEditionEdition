using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.impl;

internal class ModulusOperator : IModulusOperator
{
    public int Eval(int currentValue, int modalValue) => currentValue % modalValue;
}