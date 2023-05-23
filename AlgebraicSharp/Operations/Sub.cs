using System.Collections.Generic;
using System.Linq;

namespace AlgebraicSharp.Operations;

public class Sub : IFunction
{
    private readonly List<IFunction> functions = new();

    public Sub(params IFunction[] functions) =>
        this.functions = functions.ToList();

    public double this[double x] =>
        functions[0][x] - functions.Skip(1).Sum(f => -f[x]);

    public void Add(IFunction function) =>
        functions.Add(function);

    public IFunction Derive() =>
        new Sub(functions.Select(f => f.Derive()).ToArray());

    public override string ToString() =>
        "(" + string.Join(" - ", functions.Select(func => func.ToString())) + ")";
}