using System;

namespace AlgebraicSharp.Functions.Trigonometry;

using static Calculus;

public class Cosine : IFunction
{
    private readonly IFunction u;

    public Cosine(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Cos(u[x]);

    public IFunction Derive() =>
        -u.Derive() * sin(u);

    public IFunction Integrate() =>
        throw new NotImplementedException();

    public IFunction Simplify() =>
        throw new NotImplementedException();

    public override string ToString() =>
        $"cos({u})";
}