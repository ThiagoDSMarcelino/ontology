using static System.Math;

namespace AlgebraicSharp.Functions;

using static Calculus;

public class Logarithm : IFunction
{
    private readonly IFunction u;
    private readonly IFunction newBase;

    public Logarithm(IFunction u, IFunction newBase)
    {
        this.u = u;
        this.newBase = newBase;
    }

    public double this[double x] =>
        Log(u[x], newBase[x]);

    public IFunction Derive() =>
        u.Derive() / u * log(newBase, e);

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();

    public override string ToString() =>
        $"log{newBase}({u})";
}