﻿using System;

namespace AlgebraicSharp.Functions;

using static Calculus;

public class Secant : IFunction
{
    private readonly IFunction u;

    public Secant(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        1 / Math.Cos(x);

    public IFunction Derive() =>
        u.Derive() * cosec(u) * cosec(u);

    public IFunction Integrate() =>
        throw new NotImplementedException();

    public IFunction Simplify() =>
        throw new NotImplementedException();

    public override string ToString() =>
        $"sec({u})";
}