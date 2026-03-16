namespace FBEECSEE.Presentation.interfaces;

internal interface IEquateService
{
    bool AreEqual(int value1, int value2);

    bool AreEqual(bool value1, bool value2);
}