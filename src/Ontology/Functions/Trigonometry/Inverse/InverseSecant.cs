namespace Ontology.Functions.Trigonometry.Inverse;

public class InverseSecant : IFunction
{
    private readonly IFunction u;
    public InverseSecant(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        2 * Atan(1) - Atan(Sign(x) / Sqrt(x * x - 1));

    public IFunction Derive() =>
        u.Derive() / (u * (((u ^ 2) - 1) | 2));

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        $"arcsec({u})";
}