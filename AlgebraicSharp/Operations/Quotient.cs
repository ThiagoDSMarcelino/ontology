using System.Collections.Generic;
using System.Linq;
using System;

namespace AlgebraicSharp.Operations;

using AlgebraicSharp.Funtions;

public class Quotient : IFunction
{
    private readonly List<IFunction> functions = new();

    public Quotient(params IFunction[] functions) =>
        this.functions = functions.ToList();

    public double this[double x] =>
        functions.Skip(1).Aggregate(functions[0][x], (result, func) => result / func[x]);

    public IFunction Derive() =>
        throw new NotImplementedException();

    public override string ToString() =>
        string.Join(" / ", functions.Select(func => func.ToString()));
}