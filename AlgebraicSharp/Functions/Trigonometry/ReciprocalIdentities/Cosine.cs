using static System.Math;

namespace AlgebraicSharp.Functions.Trigonometry.ReciprocalIdentities;

using static Calculus;

public class Cosine : IFunction
{
    private readonly IFunction u;

    public Cosine(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Cos(u[x]);

    public IFunction Derive() =>
        -u.Derive() * sin(u);

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        $"cos({u})";
}