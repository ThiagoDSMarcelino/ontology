namespace Ontology.Functions.Trigonometry.ReciprocalIdentities;

using static Calculus;

public class Tangent : IFunction
{
    private readonly IFunction u;

    public Tangent(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Tan(u[x]);

    public IFunction Derive() =>
        u.Derive() * Sec(u) * Sec(u);
        
    public override string ToString() =>
        $"tg({u})";
}