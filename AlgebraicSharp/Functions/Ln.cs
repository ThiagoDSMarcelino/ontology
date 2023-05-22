using System;

namespace AlgebraicSharp.Funtions;

public class Ln : IFunction
{
    private readonly IFunction u;
    public Ln(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Log(u[x]);

    public IFunction Derive() =>
        u.Derive() / u;

    public override string ToString() =>
        $"Ln({u})";
}