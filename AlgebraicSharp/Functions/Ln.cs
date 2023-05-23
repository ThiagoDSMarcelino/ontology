using System;

namespace AlgebraicSharp.Functions;

public class Ln : IFunction
{
    private readonly IFunction u;
    public Ln(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Log(u[x]);

    public IFunction Derive() =>
        u.Derive() / u;

    public IFunction Integrate() =>
        throw new NotImplementedException();

    public IFunction Simplify() =>
        throw new NotImplementedException();

    public override string ToString() =>
        $"Ln({u})";
}