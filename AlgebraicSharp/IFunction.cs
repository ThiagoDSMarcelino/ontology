namespace AlgebraicSharp;

public interface IFunction
{
    public abstract double this[double x] { get; }
    public abstract IFunction Derive();

    #region Sum

    public static IFunction operator +(IFunction f, IFunction g) =>
        new Sum(f, g);
    public static IFunction operator +(IFunction f, double n) =>
        new Sum(f, new Constant(n));
    public static IFunction operator +(double n, IFunction f) =>
        new Sum(f, new Constant(n));

    #endregion

    #region Multiplication

    public static IFunction operator *(IFunction f, IFunction g) =>
        new Mult(f, g);
    public static IFunction operator *(IFunction f, double n) =>
        new Mult(f, new Constant(n));
    public static IFunction operator *(double n, IFunction f) =>
        new Mult(f, new Constant(n));

    #endregion
}