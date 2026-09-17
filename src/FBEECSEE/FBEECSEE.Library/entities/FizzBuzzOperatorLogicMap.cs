using FBEECSEE.Library.impl;

namespace FBEECSEE.Library.entities;

internal record FizzBuzzOperatorLogicMap(Func<FizzBuzzArrayValue, Func<bool>> ConditionEval, Func<FizzBuzzArrayValue, Action> Function);