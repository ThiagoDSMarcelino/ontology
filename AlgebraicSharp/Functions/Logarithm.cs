using System;

namespace AlgebraicSharp.Functions;

using static Calculus;

public class Logarithm : IFunction
{
    private readonly IFunction u;
    private readonly IFunction a;

    public Logarithm(IFunction u, IFunction a)
    {
        this.u = u;
        this.a = a;
    }

    public double this[double x] =>
        Math.Log(u[x], a[x]);

    public IFunction Derive() =>
        u.Derive() / u * log(e, a);

    public IFunction Integrate() =>
        throw new NotImplementedException();

    public IFunction Simplify() =>
        throw new NotImplementedException();

    public override string ToString() =>
        $"log{a}({u})";
}