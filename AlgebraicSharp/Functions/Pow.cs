using System;

namespace AlgebraicSharp.Funtions;

using static Calculus;

public class Pow : IFunction
{
    private readonly IFunction u;
    private readonly IFunction v;
    public Pow(IFunction u, IFunction v)
    {
        this.u = u;
        this.v = v;
    }

    public double this[double x] =>
        Math.Pow(u[x], v[x]);

    public IFunction Derive() =>
        v * (u ^ (v - 1)) * u.Derive() + (u ^ v) * ln(u) * v.Derive();

    public override string ToString() =>
        $"({u}^({v}))";
}