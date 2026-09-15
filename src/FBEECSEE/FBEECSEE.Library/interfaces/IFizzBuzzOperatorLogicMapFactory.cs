using FBEECSEE.Library.entities;

namespace FBEECSEE.Library.impl;

internal interface IFizzBuzzOperatorLogicMapFactory
{
    FizzBuzzOperatorLogicMap GetFizzBuzz();
    FizzBuzzOperatorLogicMap GetFizz();
    FizzBuzzOperatorLogicMap GetBuzz();
    FizzBuzzOperatorLogicMap GetNoFizzBuzz();
}