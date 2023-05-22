using System;

namespace AlgebraicSharp.Funtions;

public class Sin : IFunction
{
    private readonly IFunction u;
    public Sin(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Sin(u[x]);

    public IFunction Derive() =>
        new Cos(u) * u.Derive();

    public override string ToString() =>
        $"Sin({u})";
}