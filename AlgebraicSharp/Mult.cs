using System.Collections.Generic;
using System.Linq;
using System;

namespace AlgebraicSharp;

public class Mult : IFunction
{
    private readonly List<IFunction> functions = new();

    public Mult(params IFunction[] functions) =>
        this.functions = functions.ToList();

    public double this[double x] =>
        functions.Aggregate(1d, (result, func) => result * func[x]);

    public void Add(IFunction function) =>
        functions.Add(function);

    public IFunction Derive()
    {
        Sum result = new();

        for (int i = 0; i < functions.Count; i++)
        {
            Mult mult = new();
            for (int j = 0; j < functions.Count; j++)
                mult.Add(i == j ? functions[j].Derive() : functions[j]);

            result.Add(mult);
        }

        return result;
    }
    
    public override string ToString() =>
        "(" + String.Join(" * ", functions.Select(func => func.ToString())) + ")";
}