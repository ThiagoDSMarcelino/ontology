namespace Ontology.Functions.Trigonometry.ReciprocalIdentities;

using static Calculus;

public class Secant : IFunction
{
    private readonly IFunction u;

    public Secant(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        1 / Math.Cos(x);

    public IFunction Derive() =>
        u.Derive() * Sec(u) * Tg(u);

    public override string ToString() =>
        $"sec({u})";
}