namespace AlgebraicSharp.Functions.Trigonometry.Inverse;

public class InverseTangent : IFunction
{
    private readonly IFunction u;
    public InverseTangent(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        System.Math.Atan(x);

    public IFunction Derive() =>
        u.Derive() / (1 + (u ^ 2));

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        $"arctg({u})";
}