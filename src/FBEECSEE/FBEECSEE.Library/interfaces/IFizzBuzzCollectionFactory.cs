namespace FBEECSEE.Library.interfaces;

internal interface IFizzBuzzCollectionFactory
{
    FizzBuzzCollection Create(IEnumerable<FizzBuzzArrayValue> fizzBuzzArrayValues);
}