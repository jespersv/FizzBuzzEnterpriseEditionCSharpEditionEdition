using FBEECSEE.Library.entities;

namespace FBEECSEE.Library.impl;

internal class FizzBuzzLogicDictionary
{
    private readonly Dictionary<FizzBuzzEnum, EvaluationActionBinding<int>> _map = new();

    internal IEnumerable<FizzBuzzEnum> Keys => _map.Keys;

    internal void Add(FizzBuzzLogicMap map)
    {
        _map.Add(map.Key, map.Value);
    }

    internal EvaluationActionBinding<int> this[FizzBuzzEnum key] => _map[key];
}
