using FBEECSEE.Presentation.entities;
using FBEECSEE.Presentation.impl;

namespace FBEECSEE.Presentation.interfaces;

internal interface IFizzBuzzLogicMapperFactory
{
    Dictionary<FizzBuzzEnum, EvaluationActionBinding<int>> CreateMapper();
}