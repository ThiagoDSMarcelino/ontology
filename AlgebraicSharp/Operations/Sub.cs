using System.Collections.Generic;
using System.Linq;

namespace AlgebraicSharp.Operations;

public class Sub : IFunction
{
    private readonly List<IFunction> functions = new();

    public Sub(params IFunction[] functions) =>
        this.functions = functions.ToList();

    public double this[double x] =>
        functions.Skip(1).Aggregate(functions[0][x], (result, f) => result - f[x]);

    public void Add(IFunction function) =>
        functions.Add(function);

    public IFunction Derive() =>
        new Sub(functions.Select(f => f.Derive()).ToArray());

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        "(" + string.Join(" - ", functions.Select(func => func.ToString())) + ")";
}