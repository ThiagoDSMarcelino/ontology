﻿namespace Ontology.Functions.Trigonometry.ReciprocalIdentities;

using static Calculus;

public class Cotangent : IFunction
{
    private readonly IFunction u;

    public Cotangent(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        1 / Math.Tan(x);

    public IFunction Derive() =>
        -u.Derive() * Csc(u) * Csc(u);

    public override string ToString() =>
        $"cotg({u})";
}