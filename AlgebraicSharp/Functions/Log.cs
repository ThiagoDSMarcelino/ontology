using System;

namespace AlgebraicSharp.Functions;

using static Calculus;

public class Log : IFunction
{
    private readonly IFunction u;
    private readonly double a;

    public Log(IFunction u, double a)
    {
        this.u = u;
        this.a = a;
    }

    public double this[double x] =>
        Math.Log(u[x], a);

    public IFunction Derive() =>
        u.Derive() / u * log(e, a);

    public override string ToString() =>
        $"Log{a}({u})";
}