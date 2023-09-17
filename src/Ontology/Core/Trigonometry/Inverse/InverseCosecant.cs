namespace Ontology.Functions.Trigonometry.Inverse;

using static Calculus;

public class InverseCosecant : IFunction
{
    private readonly IFunction u;
    public InverseCosecant(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Math.Atan(Math.Sign(x) / Math.Sqrt(x * x - 1));

    public IFunction Derive() =>
        -u.Derive() / (u * Sqrt(Pow(u, 2) - 1, 2));

    public override string ToString() =>
        $"arccsc({u})";
}