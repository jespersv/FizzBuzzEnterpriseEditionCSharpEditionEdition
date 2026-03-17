using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.impl;

internal class EquateService : IEquateService
{
    public bool AreEqual(int value1, int value2) => value1.Equals(value2);
}