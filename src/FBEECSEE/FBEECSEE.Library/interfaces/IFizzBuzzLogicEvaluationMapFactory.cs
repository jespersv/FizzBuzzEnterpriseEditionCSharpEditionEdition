namespace FBEECSEE.Library.interfaces;

internal interface IFizzBuzzLogicEvaluationMapFactory
{
    FizzBuzzLogicMap CreateFizzBuzzLogicMap();
    FizzBuzzLogicMap CreateBuzzLogicMap();
    FizzBuzzLogicMap CreateFizzLogicMap();
    FizzBuzzLogicMap CreateNoFizzBuzzLogicMap();
}