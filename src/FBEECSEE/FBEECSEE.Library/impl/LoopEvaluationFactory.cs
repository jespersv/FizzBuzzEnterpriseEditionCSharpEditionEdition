using FBEECSEE.Library.util.functional;

namespace FBEECSEE.Library.impl;

internal class LoopEvaluationFactory : ILoopEvaluationFactory
{
    private readonly IFizzBuzzOperatorLogicMapFactory _factory;

    public LoopEvaluationFactory(IFizzBuzzOperatorLogicMapFactory factory)
    {
        _factory = factory;
    }

    public Func<FizzBuzzArrayValue, IfTee> Create()
    {
        var fizzBuzzOperatorLogicMap = _factory.GetFizzBuzz();
        var fizzOperatorLogicMap = _factory.GetFizz();
        var buzzOperatorLogicMap = _factory.GetBuzz();
        var nfBuzzOperatorLogicMap = _factory.GetNoFizzBuzz();

        return value => If.Tee()
            .If(fizzBuzzOperatorLogicMap.ConditionEval(value), fizzBuzzOperatorLogicMap.Function(value))
            .ElseIf(fizzOperatorLogicMap.ConditionEval(value), fizzOperatorLogicMap.Function(value))
            .ElseIf(buzzOperatorLogicMap.ConditionEval(value), buzzOperatorLogicMap.Function(value))
            .Else(nfBuzzOperatorLogicMap.Function(value))
            .Build();
    }
}