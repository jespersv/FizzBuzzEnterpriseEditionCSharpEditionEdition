using System.Collections;

namespace FBEECSEE.Library.entities;

internal class FizzBuzzCollection(IEnumerable<FizzBuzzArrayValue> values) : IEnumerable<FizzBuzzArrayValue>
{
    public IEnumerator<FizzBuzzArrayValue> GetEnumerator() => (values).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}