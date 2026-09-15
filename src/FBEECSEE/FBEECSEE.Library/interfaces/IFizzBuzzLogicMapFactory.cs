using FBEECSEE.Library.impl;

namespace FBEECSEE.Library.interfaces;

internal interface IFizzBuzzLogicMapFactory
{
    FizzBuzzLogicMap CreateFizzBuzzLogicMap();
    FizzBuzzLogicMap CreateBuzzLogicMap();
    FizzBuzzLogicMap CreateFizzLogicMap();
    FizzBuzzLogicMap CreateNoFizzBuzzLogicMap();
}