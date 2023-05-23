﻿using System;

namespace AlgebraicSharp.Functions;

using static Calculus;

public class Sin : IFunction
{
    private readonly IFunction u;
    public Sin(IFunction u) =>
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
        $"Sin({u})";
}