namespace Ontology.Functions.Trigonometry.ReciprocalIdentities;

using static Calculus;

public class Secant : IFunction
{
    private readonly IFunction u;

    public Secant(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        1 / Cos(x);

    public IFunction Derive() =>
        u.Derive() * sec(u) * tg(u);

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        $"sec({u})";
}