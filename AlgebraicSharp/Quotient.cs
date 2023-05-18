using System;

namespace AlgebraicSharp;

public class Quotient : IFunction
{
    private readonly IFunction f;
    private readonly IFunction g;

    public Quotient(IFunction f, IFunction g)
    {
        this.f = f;
        this.g = g;
    }

    public double this[double x] =>
        f[x]/g[x];

    public IFunction Derive() =>
        throw new NotImplementedException();
    
    public override string ToString() =>
        $"{f}/{g}";
}