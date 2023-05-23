using System;

namespace AlgebraicSharp.Functions;

public class Cosine : IFunction
{
    private readonly IFunction u;

    public Cosine(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Cos(u[x]);

    public IFunction Derive() =>
        new Sine(u) * u.Derive();

    public IFunction Integrate() =>
        throw new NotImplementedException();

    public IFunction Simplify() =>
        throw new NotImplementedException();

    public override string ToString() =>
        $"cos({u})";
}