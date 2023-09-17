namespace Ontology.Functions;

using static Calculus;

public class Logarithm : IFunction
{
    private readonly IFunction u;
    private readonly IFunction a;

    public Logarithm(IFunction u, IFunction a)
    {
        this.u = u;
        this.a = a;
    }

    public double this[double x] =>
        Math.Log(u[x], a[x]);

    public IFunction Derive() =>
        u.Derive() / u * Log(a, E);


    public override string ToString() =>
        $"log{a}({u})";
}