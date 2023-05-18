namespace AlgebraicAbstractionOfFunctions;

public class Constant : IFunction
{
    private readonly double u;

    public Constant(double u) =>
        this.u = u;

    public double this[double x] =>
        u;

    public IFunction Derive() =>
        new Constant(0);
}