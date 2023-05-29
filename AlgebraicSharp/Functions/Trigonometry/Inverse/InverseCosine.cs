using static System.Math;

namespace AlgebraicSharp.Functions.Trigonometry.Inverse;

public class InverseCosine : IFunction
{
    private readonly IFunction u;
    public InverseCosine(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Acos(x);

    public IFunction Derive() =>
        -u.Derive() / ((1 - (u ^ 2)) | 2);

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        $"arccos({u})";
}