using AlgebraicSharp.Functions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgebraicSharp.Operations;

using static Calculus;

public class Exponentiation : IFunction
{
    private readonly List<IFunction> functions = new();

    public Exponentiation(params IFunction[] functions) =>
        this.functions = functions.ToList();

    public double this[double x] =>
        Math.Pow(functions[0][x], functions.Skip(1).Aggregate(1d, (result, func) => result * func[x]));

    public void Add(IFunction function) =>
        functions.Add(function);

    public IFunction Derive()
    {
        var u = functions[0];
        var v = functions[1];

        return v * (u ^ v - 1) * u.Derive() + (u ^ v) * ln(u) * v.Derive();
    }

    public IFunction Integrate() =>
        throw new NotImplementedException();

    public IFunction Simplify() =>
        throw new NotImplementedException();

    public override string ToString() =>
        $"({functions[0]})^({functions.Skip(1).Aggregate((IFunction)(new Constant(1)), (result, func) => result * func).ToString().Remove(0, 4)})";
}