using static System.Math;

namespace AlgebraicSharp.Functions.Trigonometry.ReciprocalIdentities;

using static Calculus;

public class Sine : IFunction
{
    private readonly IFunction u;
    public Sine(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Sin(u[x]);

    public IFunction Derive() =>
        cos(u) * u.Derive();

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        $"sin({u})";
}