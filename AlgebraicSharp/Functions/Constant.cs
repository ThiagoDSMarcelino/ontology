namespace AlgebraicSharp.Functions;

public class Constant : IFunction
{
    private readonly double n;

    public Constant(double n) =>
        this.n = n;

    public double this[double x] =>
        n;

    public IFunction Derive() =>
        new Constant(0);

    public IFunction Integrate() =>
        throw new System.NotImplementedException();

    public IFunction Simplify() =>
        throw new System.NotImplementedException();


    public override string ToString() =>
        n.ToString();
}