namespace Ontology.Functions.Trigonometry.Inverse;

using static Calculus;

public class InverseSecant : IFunction
{
    private readonly IFunction u;
    public InverseSecant(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        2 * Math.Atan(1) - Math.Atan(Math.Sign(x) / Math.Sqrt(x * x - 1));

    public IFunction Derive() =>
        u.Derive() / (u * Sqrt(Pow(u, 2) - 1, 2));

    public override string ToString() =>
        $"arcsec({u})";
}