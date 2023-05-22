using System;

namespace AlgebraicSharp.Funtions;

using static Calculus;

public class Pow : IFunction
{
    private readonly IFunction a;
    private readonly IFunction u;
    public Pow(IFunction a, IFunction u)
    {
        this.a = a;
        this.u = u;
    }

    public double this[double x] =>
        Math.Pow(a[x], u[x]);

    public IFunction Derive() =>
        a^u * ln(a) * u.Derive();

    public override string ToString() =>
        $"{a}^({u})";
}