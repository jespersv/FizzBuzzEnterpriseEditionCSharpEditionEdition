using FBEECSEE.Library.entities;
using FBEECSEE.Library.impl;

namespace FBEECSEE.Library.interfaces;

internal interface IFizzBuzzLogicEvaluationMapperFactory
{
    Dictionary<FizzBuzzEnum, EvaluationActionBinding<int>> CreateMapper();
}