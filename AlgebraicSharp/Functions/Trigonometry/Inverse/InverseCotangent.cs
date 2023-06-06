namespace AlgebraicSharp.Functions.Trigonometry.Inverse;

public class InverseCotangent : IFunction
{
    private readonly IFunction u;
    public InverseCotangent(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        2 * Atan(1) - Atan(x);

    public IFunction Derive() =>
        -u.Derive() / (1 + (u ^ 2));

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        $"arccot({u})";
}