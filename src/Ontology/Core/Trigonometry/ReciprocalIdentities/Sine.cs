namespace Ontology.Functions.Trigonometry.ReciprocalIdentities;

using static Calculus;

public class Sine : IFunction
{
    private readonly IFunction u;
    public Sine(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Sin(u[x]);

    public IFunction Derive() =>
        Cos(u) * u.Derive();

    public override string ToString() =>
        $"sin({u})";
}