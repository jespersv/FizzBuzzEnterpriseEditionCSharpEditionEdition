namespace FBEECSEE.Library.interfaces;

internal interface IModulusCompareService
{
    bool Check(int value, int modulus, int modulusCompareValue);
}