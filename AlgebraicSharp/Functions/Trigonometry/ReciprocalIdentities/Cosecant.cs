using System;

namespace AlgebraicSharp.Functions.Trigonometry.ReciprocalIdentities;

using static Calculus;

public class Cosecant : IFunction
{
    private readonly IFunction u;

    public Cosecant(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        1 / Math.Sin(x);

    public IFunction Derive() =>
        -u.Derive() * csc(u) * cot(u);


    public IFunction Integrate() =>
        throw new NotImplementedException();

    public IFunction Simplify() =>
        throw new NotImplementedException();

    public override string ToString() =>
        $"cosec({u})";
}