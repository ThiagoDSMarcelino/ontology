namespace Ontology.Functions.Trigonometry.ReciprocalIdentities;

using static Calculus;

public class Cotangent : IFunction
{
    private readonly IFunction u;

    public Cotangent(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        1 / Tan(x);

    public IFunction Derive() =>
        -u.Derive() * csc(u) * csc(u);

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        $"cotg({u})";
}