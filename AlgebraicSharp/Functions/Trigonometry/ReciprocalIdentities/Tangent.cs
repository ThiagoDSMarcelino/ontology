namespace AlgebraicSharp.Functions.Trigonometry.ReciprocalIdentities;

using static Calculus;

public class Tangent : IFunction
{
    private readonly IFunction u;

    public Tangent(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Tan(u[x]);

    public IFunction Derive() =>
        u.Derive() * sec(u) * sec(u);

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        $"tg({u})";
}