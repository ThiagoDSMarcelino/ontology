namespace Ontology.Functions.Trigonometry.Inverse;

using static Calculus;

public class InverseCosine : IFunction
{
    private readonly IFunction u;
    public InverseCosine(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Acos(x);

    public IFunction Derive() =>
        -u.Derive() / Sqrt(1 - Pow(u, 2), 2);

    public override string ToString() =>
        $"arccos({u})";
}