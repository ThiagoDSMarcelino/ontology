using System.Collections.Generic;
using System.Linq;
using System;

namespace AlgebraicAbstractionOfFunctions;

public class Mult : IFunction
{
    private readonly List<IFunction> functions = new();

    public Mult(params IFunction[] functions) =>
        this.functions = functions.ToList();

    public double this[double x] =>
        functions.Aggregate(1d, (result, func) => result * func[x]);

    public void Add(IFunction function) =>
        functions.Add(function);

    public IFunction Derive() =>
        throw new NotImplementedException();
}