namespace Ontology.Functions.Trigonometry.Inverse;

using static Calculus;

public class InverseTangent : IFunction
{
    private readonly IFunction u;
    public InverseTangent(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Atan(x);

    public IFunction Derive() =>
        u.Derive() / (1 + Pow(u, 2));

    public override string ToString() =>
        $"arctg({u})";
}