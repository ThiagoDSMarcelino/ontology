using static System.Math;

namespace AlgebraicSharp.Functions.Trigonometry.Inverse;

public class InverseSine : IFunction
{
    private readonly IFunction u;
    public InverseSine(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Atan(u[x] / Sqrt(-u[x] * u[x] + 1));

    public IFunction Derive() =>
        1 / ((1 - (u^2)) | 2);

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        $"arcsin({u})";
}