using System;

namespace AlgebraicSharp;

public class Cos : IFunction
{
    private readonly IFunction u;
    public Cos(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Sin(u[x]);

    public IFunction Derive() =>
        new Mult(new Sin(u), u.Derive());

    public override string ToString() =>
        $"Cos({u})";
}