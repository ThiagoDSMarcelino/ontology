using System;

namespace AlgebraicAbstractionOfFunctions;

public class Cos : IFunction
{
    private readonly IFunction u;
    public Cos(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Sin(u[x]);

    public IFunction Derive() =>
        new Mult();
}