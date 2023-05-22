namespace AlgebraicSharp.Funtions;

using AlgebraicSharp.Operations;

public interface IFunction
{
    public abstract double this[double x] { get; }
    public abstract IFunction Derive();

    #region Sum

    public static IFunction operator +(IFunction f, IFunction g) =>
        new Sum(f, g);
    public static IFunction operator +(double n, IFunction f) =>
        new Sum(f, new Constant(n));
    public static IFunction operator +(IFunction f, double n) =>
        new Sum(f, new Constant(n));

    #endregion

    #region Sub

    public static IFunction operator -(IFunction f, IFunction g) =>
        new Sub(f, g);
    public static IFunction operator -(double n, IFunction f) =>
        new Sub(f, new Constant(n));
    public static IFunction operator -(IFunction f, double n) =>
        new Sub(f, new Constant(n));

    #endregion

    #region Multiplication

    public static IFunction operator *(IFunction f, IFunction g) =>
        new Product(f, g);
    public static IFunction operator *(double n, IFunction f) =>
        new Product(f, new Constant(n));
    public static IFunction operator *(IFunction f, double n) =>
        new Product(f, new Constant(n));

    #endregion

    #region Quotient

    public static IFunction operator /(IFunction f, IFunction g) =>
        new Product(f, g^-1);
    public static IFunction operator /(double f, IFunction g) =>
        new Product(new Constant(f), g^-1);
    public static IFunction operator /(IFunction f, double g) =>
        new Product(f, (IFunction)new Constant(g)^-1);

    #endregion

    #region Pow

    public static IFunction operator ^(IFunction a, IFunction u) =>
        new Pow(a, u);
    public static IFunction operator ^(double a, IFunction u) =>
        new Pow( new Constant(a), u);
    public static IFunction operator ^(IFunction a, double u) =>
        new Pow(a, new Constant(u));

    #endregion
}