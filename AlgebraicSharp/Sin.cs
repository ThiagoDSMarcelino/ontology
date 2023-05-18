using System;

namespace AlgebraicAbstractionOfFunctions;

public class Sin : IFunction
{
    private readonly IFunction u;
    public Sin(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Sin(u[x]);

    public IFunction Derive() =>
        new Mult(u.Derive(), new Cos(u));
}