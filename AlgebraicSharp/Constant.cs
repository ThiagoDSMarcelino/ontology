namespace AlgebraicSharp;

public class Constant : IFunction
{
    private readonly double n;

    public Constant(double n) =>
        this.n = n;

    public double this[double x] =>
        n;

    public IFunction Derive() =>
        new Constant(0);

    public override string ToString() =>
        n.ToString();
}