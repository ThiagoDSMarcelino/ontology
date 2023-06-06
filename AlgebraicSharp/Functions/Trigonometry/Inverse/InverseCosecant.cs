namespace AlgebraicSharp.Functions.Trigonometry.Inverse;

public class InverseCosecant : IFunction
{
    private readonly IFunction u;
    public InverseCosecant(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        Atan(Sign(x) / Sqrt(x * x - 1));

    public IFunction Derive() =>
        -u.Derive() / (u * (((u ^ 2) - 1) | 2));

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        $"arccsc({u})";
}