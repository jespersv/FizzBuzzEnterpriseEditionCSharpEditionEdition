namespace FBEECSEE.Library.impl;

internal class FizzBuzzCollectionFactory : IFizzBuzzCollectionFactory
{
    public FizzBuzzCollection Create(IEnumerable<FizzBuzzArrayValue> fizzBuzzArrayValues)
    {
        return new FizzBuzzCollection(fizzBuzzArrayValues);
    }
}