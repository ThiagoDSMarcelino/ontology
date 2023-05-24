using System;

namespace AlgebraicSharp.Functions.Trigonometry.ReciprocalIdentities;

using static Calculus;

public class Sine : IFunction
{
    private readonly IFunction u;
    public Sine(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Sin(u[x]);

    public IFunction Derive() =>
        cos(u) * u.Derive();

    public IFunction Integrate() =>
        throw new NotImplementedException();

    public IFunction Simplify() =>
        throw new NotImplementedException();

    public override string ToString() =>
        $"sin({u})";
}