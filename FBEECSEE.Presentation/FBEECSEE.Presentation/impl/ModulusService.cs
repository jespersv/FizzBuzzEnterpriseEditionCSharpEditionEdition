using FBEECSEE.Presentation.interfaces;

namespace FBEECSEE.Presentation.impl;

internal class ModulusService : IModulusService
{
    public int Eval(int currentValue, int modalValue)
    {
        return currentValue % modalValue;
    }
}