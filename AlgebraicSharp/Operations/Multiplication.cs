using System.Collections.Generic;
using System.Linq;

namespace AlgebraicSharp.Operations;

using AlgebraicSharp.Funtions;

public class Multiplication : IFunction
{
    private readonly List<IFunction> functions = new();

    public Multiplication(params IFunction[] functions) =>
        this.functions = functions.ToList();

    public double this[double x] =>
        functions.Aggregate(1d, (result, func) => result * func[x]);

    public void Add(IFunction function) =>
        functions.Add(function);

    public IFunction Derive() =>
        new Sum(functions.Select(
            (_, i) => new Multiplication(functions.Select(
                (func, j) => i == j ? functions[j].Derive() : functions[j]).ToArray())).ToArray());

    public override string ToString() =>
        "(" + string.Join(" * ", functions.Select(func => func.ToString())) + ")";
}