using System.Collections.Generic;
using System.Linq;

namespace AlgebraicSharp.Functions.Operations;

public class Sum : IFunction
{
    private readonly List<IFunction> functions = new();

    public Sum(params IFunction[] functions) =>
        this.functions = functions.ToList();

    public double this[double x] =>
        functions.Sum(f => f[x]);

    public void Add(IFunction function) =>
        functions.Add(function);

    public void Add(IFunction function, int index, bool isSubtraction = false)
    {
        if (isSubtraction)
        {
            functions.Insert(index, function);
            functions[1] = -functions[1];
        }

        else
            functions.Insert(index, function);
    }

    public IFunction Derive() =>
        new Sum(functions.Select(f => f.Derive()).ToArray());

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        "(" + string.Join(" + ", functions.Select(func => func.ToString())) + ")";
}