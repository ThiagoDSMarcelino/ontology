namespace Ontology.Functions.Trigonometry.Inverse;

using static Calculus;

public class InverseCotangent : IFunction
{
    private readonly IFunction u;
    public InverseCotangent(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        2 * Math.Atan(1) - Math.Atan(x);

    public IFunction Derive() =>
        -u.Derive() / (1 + Pow(u, 2));

    public override string ToString() =>
        $"arccot({u})";
}