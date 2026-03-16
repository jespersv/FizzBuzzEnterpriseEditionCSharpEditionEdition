using FBEECSEE.Presentation.interfaces;

namespace FBEECSEE.Presentation.impl;

internal class EquateService : IEquateService
{
    public bool AreEqual(int value1, int value2) => value1.Equals(value2);

    public bool AreEqual(bool value1, bool value2) => value1.Equals(value2);
}