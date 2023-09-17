namespace Ontology.Functions.Trigonometry.ReciprocalIdentities;

using static Calculus;

public class Cosine : IFunction
{
    private readonly IFunction u;

    public Cosine(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Cos(u[x]);

    public IFunction Derive() =>
        -u.Derive() * Sin(u);

    public override string ToString() =>
        $"cos({u})";
}