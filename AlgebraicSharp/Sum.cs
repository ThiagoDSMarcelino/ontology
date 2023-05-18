using System.Collections.Generic;
using System.Linq;
using System;

namespace AlgebraicSharp;

public class Sum : IFunction
{

    private readonly List<IFunction> functions = new();

    public Sum(params IFunction[] functions) =>
        this.functions = functions.ToList();

    public double this[double x] =>
        functions.Sum(f => f[x]);

    public void Add(IFunction function) =>
        functions.Add(function);

    public IFunction Derive() =>
        new Sum(functions.Select(f => f.Derive()).ToArray());

    public override string ToString() =>
        "(" + String.Join(" + ", functions.Select(func => func.ToString())) + ")";
}