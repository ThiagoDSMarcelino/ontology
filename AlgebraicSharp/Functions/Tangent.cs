﻿using System;

namespace AlgebraicSharp.Functions;

using static Calculus;

public class Tangent : IFunction
{
    private readonly IFunction u;

    public Tangent(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Tan(u[x]);

    public IFunction Derive() =>
        u.Derive() * sec(u) * sec(u);

    public IFunction Integrate() =>
        throw new NotImplementedException();

    public IFunction Simplify() =>
        throw new NotImplementedException();

    public override string ToString() =>
        $"tg({u})";
}