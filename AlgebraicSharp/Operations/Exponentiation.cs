using System.Collections.Generic;
using System.Linq;
using System;

namespace AlgebraicSharp.Operations;

using static Calculus;

public class Exponentiation : IFunction
{
    private readonly List<IFunction> functions = new();

    public Exponentiation(params IFunction[] functions) =>
        this.functions = functions.ToList();

    private IFunction getExponent() =>
        functions.Skip(2).Aggregate(functions[1], (result, func) => result * func);

    public double this[double x] =>
        Math.Pow(functions[0][x], getExponent()[x]);

    public void Add(IFunction function) =>
        functions.Add(function);

    public void Add(IFunction function, int index) =>
        functions.Insert(index, function);

    public IFunction Derive()
    {
        var u = functions[0];
        var v = getExponent();

        return v * (u ^ v - 1) * u.Derive() + (u ^ v) * ln(u) * v.Derive();
    }

    public IFunction Integrate() =>
        throw new NotImplementedException();

    public IFunction Simplify() =>
        throw new NotImplementedException();

    public override string ToString() =>
        $"{functions[0]}^{getExponent()}";
}