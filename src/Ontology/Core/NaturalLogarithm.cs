namespace Ontology.Functions;

using static Calculus;

public class NaturalLogarithm : IFunction
{
    private readonly IFunction u;

    public NaturalLogarithm(IFunction u)
        => this.u = u;

    public double this[double x] =>
        Math.Log(u[x]);

    public IFunction Derive() =>
        u.Derive() / u;

    public override string ToString() =>
        $"ln({u})";
}