using System;

namespace AlgebraicSharp.Functions;

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

    public IFunction Integrate() =>
        throw new NotImplementedException();

    public IFunction Simplify() =>
        throw new NotImplementedException();

    public override string ToString() =>
        $"({u}^({v}))";
}