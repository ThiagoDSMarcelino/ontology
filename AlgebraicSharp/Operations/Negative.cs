namespace AlgebraicSharp.Operations;

public class Negative : IFunction
{
    private readonly IFunction u;

    public Negative(IFunction u) =>
        this.u = u;

    public double this[double x] =>
        -u[x];

    public IFunction Derive() =>
        -u.Derive();

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        "(-" + u.ToString() + ")";
}