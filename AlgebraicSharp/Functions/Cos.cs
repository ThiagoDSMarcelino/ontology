using System;

namespace AlgebraicSharp.Functions;

public class Cos : IFunction
{
    private readonly IFunction u;

    public Cos(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Cos(u[x]);

    public IFunction Derive() =>
        new Sin(u) * u.Derive();

    public IFunction Integrate() =>
        throw new NotImplementedException();

    public IFunction Simplify() =>
        throw new NotImplementedException();

    public override string ToString() =>
        $"Cos({u})";
}