namespace FBEECSEE.Library.entities;

internal record FizzBuzzOperatorLogicMap(Func<int, Func<bool>> ConditionEval, Func<int, Action> Function);