using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.impl;

internal class ModulusService : IModulusService
{
    public int Eval(int currentValue, int modalValue)
    {
        return currentValue % modalValue;
    }
}