namespace Ontology.Functions.Trigonometry.ReciprocalIdentities;

using static Calculus;

public class Cosecant : IFunction
{
    private readonly IFunction u;

    public Cosecant(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        1 / Math.Sin(x);

    public IFunction Derive() =>
        -u.Derive() * Csc(u) * Cot(u);

    public override string ToString() =>
        $"cosec({u})";
}