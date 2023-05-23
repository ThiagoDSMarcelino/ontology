using System;

namespace AlgebraicSharp.Functions;

using static Calculus;

public class Logarithm : IFunction
{
    private readonly IFunction a;
    private readonly IFunction u;

    public Logarithm(IFunction a, IFunction u)
    {
        this.a = a;
        this.u = u;
    }

    public double this[double x] =>
        Math.Log(u[x], a[x]);

    public IFunction Derive() =>
        u.Derive() / u * log(a, e);

    public IFunction Integrate() =>
        throw new NotImplementedException();

    public IFunction Simplify() =>
        throw new NotImplementedException();

    public override string ToString() =>
        $"log{a}({u})";
}