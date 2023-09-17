namespace Ontology.Operations;

using static Calculus;

public class Exponentiation : IFunction
{
    private readonly List<IFunction> functions = new();

    public Exponentiation(params IFunction[] functions) =>
        this.functions = functions.ToList();

    private IFunction GetExponent() =>
        functions.Skip(2).Aggregate(functions[1], (result, func) => result * func);

    public double this[double x] =>
        Math.Pow(functions[0][x], GetExponent()[x]);

    public void Add(IFunction function) =>
        functions.Add(function);

    public void Add(IFunction function, int index) =>
        functions.Insert(index, function);

    public IFunction Derive()
    {
        var u = functions[0];
        var v = GetExponent();

        return v * Pow(u, v - 1) * u.Derive() + Pow(u, v) * Ln(u) * v.Derive();
    }

    public override string ToString() =>
        $"{functions[0]}^{GetExponent()}";
}