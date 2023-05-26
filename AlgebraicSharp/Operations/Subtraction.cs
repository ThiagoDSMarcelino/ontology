using System.Collections.Generic;
using System.Linq;

namespace AlgebraicSharp.Operations;

public class Subtraction : IFunction
{
    private readonly List<IFunction> functions = new();

    public Subtraction(params IFunction[] functions) =>
        this.functions = functions.ToList();

    public double this[double x] =>
        functions.Skip(1).Aggregate(functions[0][x], (result, f) => result - f[x]);

    public void Add(IFunction function) =>
        functions.Add(function);

    public void Add(IFunction function, int index) =>
        functions.Insert(index, function);

    public IFunction Derive() =>
        new Subtraction(functions.Select(f => f.Derive()).ToArray());

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        "(" + string.Join(" - ", functions.Select(func => func.ToString())) + ")";
}