using System;

namespace AlgebraicSharp.Functions;

public class Cosecant : IFunction
{
    private readonly IFunction u;

    public Cosecant(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        1 / Math.Sin(x);

    public IFunction Derive() =>
        throw new NotImplementedException();

    public IFunction Integrate() =>
        throw new NotImplementedException();

    public IFunction Simplify() =>
        throw new NotImplementedException();

    public override string ToString() =>
        $"cosec({u})";
}