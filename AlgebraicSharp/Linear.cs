namespace AlgebraicSharp;

internal class Linear : IFunction
{
    public double this[double x] =>
        x;

    public IFunction Derive() =>
        new Constant(1);

    public override string ToString() =>
        "x";
}