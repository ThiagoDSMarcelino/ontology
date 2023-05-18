using System;

namespace AlgebraicSharp;

public class Ln : IFunction
{
    private readonly IFunction u;
    public Ln(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Log(u[x]);

    public IFunction Derive() =>
        throw new NotImplementedException();
    
    public override string ToString() =>
        $"Ln({u})";
}