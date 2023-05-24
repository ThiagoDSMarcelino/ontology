using System;

namespace AlgebraicSharp.Functions.Trigonometry.Inverse;

using static Calculus;

public class InverseSine : IFunction
{
    private readonly IFunction u;
    public InverseSine(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Atan(u[x] / Math.Sqrt(-u[x] * u[x] + 1));

    public IFunction Derive() =>
        1 / ((1 - (u^2)) | 2);

    public IFunction Integrate() =>
        throw new NotImplementedException();

    public IFunction Simplify() =>
        throw new NotImplementedException();

    public override string ToString() =>
        $"arcsin({u})";
}