using System;

namespace AlgebraicSharp.Functions.Trigonometry;

using static Calculus;

public class Cotangent : IFunction
{
    private readonly IFunction u;

    public Cotangent(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        1 / Math.Tan(x);

    public IFunction Derive() =>
        -u.Derive() * cosec(u) * cosec(u);

    public IFunction Integrate() =>
        throw new NotImplementedException();

    public IFunction Simplify() =>
        throw new NotImplementedException();

    public override string ToString() =>
        $"cosec({u})";
}