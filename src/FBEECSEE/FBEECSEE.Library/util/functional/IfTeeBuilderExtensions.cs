namespace FBEECSEE.Library.util.functional;

public static class IfTeeBuilderExtensions
{
    public static IfTeeBuilder If(this IfTeeBuilder @this, Func<bool> con, Action fn) => 
        (IfTeeBuilder)@this.AddIf(con, fn);

    public static IfTeeBuilder If(this IfTeeBuilder @this, bool con, Action fn) =>
        @this.If(() => con, fn);

    public static void IfRun(this IfTeeBuilder @this, Func<bool> con, Action fn) => 
        @this.If(con, fn).Run();

    public static void IfRun(this IfTeeBuilder @this, bool con, Action fn) =>
        @this.If(() => con, fn).Run();

    public static IfTeeBuilder ElseIf(this IfTeeBuilder @this, Func<bool> con, Action fn) =>
        (IfTeeBuilder)@this.AddElseIf(con, fn);

    public static IfTeeBuilder ElseIf(this IfTeeBuilder @this, bool con, Action fn) =>
        @this.ElseIf(() => con, fn);

    public static void ElseIfRun(this IfTeeBuilder @this, Func<bool> con, Action fn) =>
        @this.ElseIf(con, fn).Run();

    public static void ElseIfRun(this IfTeeBuilder @this, bool con, Action fn) =>
        @this.ElseIf(() => con, fn).Run();

    public static IfTeeBuilder Else(this IfTeeBuilder @this, Action fn) => 
        (IfTeeBuilder)@this.AddElse(fn);

    public static void ElseRun(this IfTeeBuilder @this, Action fn) => 
        @this.Else(fn).Run();

    public static void Run(this IfTeeBuilder @this) => 
        @this.Build().Run();
}