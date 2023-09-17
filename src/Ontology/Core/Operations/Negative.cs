namespace Ontology.Operations;

public class Negative : IFunction
{
    private readonly IFunction u;

    public Negative(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        -u[x];

    public IFunction Derive() =>
        -u.Derive();

    public override string ToString() =>
        "(-(" + u.ToString() + "))";
}