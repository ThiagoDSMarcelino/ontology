namespace Ontology.Functions.Trigonometry.Inverse;

using static Calculus;

public class InverseSine : IFunction
{
    private readonly IFunction u;
    public InverseSine(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Asin(x);

    public IFunction Derive() =>
        u.Derive() / Sqrt(1 - Pow(u, 2), 2);
    public override string ToString() =>
        $"arcsin({u})";
}