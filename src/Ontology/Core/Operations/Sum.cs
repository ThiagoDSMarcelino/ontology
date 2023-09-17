namespace Ontology.Operations;

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
        functions.Insert(index, function);

        if (isSubtraction)
            functions[1] = -functions[1];
    }

    public IFunction Derive() =>
        new Sum(functions.Select(f => f.Derive()).ToArray());

    public override string ToString() =>
        "(" + string.Join(" + ", functions.Select(func => func.ToString())) + ")";
}