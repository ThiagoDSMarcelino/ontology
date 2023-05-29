namespace AlgebraicSharp.Functions;

using Operations;

public interface IFunction
{
    double this[double x] { get; }

    IFunction Derive();
    IFunction Integrate();
    IFunction Simplify();

    #region Sum

    private static IFunction sum(IFunction f, IFunction g)
    {
        if (f is Sum fFunc)
        {
            fFunc.Add(g);

            return fFunc;
        }
        else if (g is Sum gFunc)
        {
            gFunc.Add(f, 0);

            return gFunc;
        }

        return new Sum(f, g);
    }
    public static IFunction operator +(IFunction f, IFunction g) =>
        sum(f, g);
    public static IFunction operator +(double n, IFunction f) =>
        sum(new Constant(n), f);
    public static IFunction operator +(IFunction f, double n) =>
        sum(f, new Constant(n));

    #endregion

    #region Subtraction

    public static IFunction operator -(IFunction f) =>
        new Negative(f);
    public static IFunction operator -(IFunction f, IFunction g)
    {
        if (f is Sum fFunc)
        {
            fFunc.Add(-g);

            return fFunc;
        }
        else if (g is Sum gFunc)
        {
            gFunc.Add(f, 0, true);

            return gFunc;
        }

        return new Sum(f, -g);
    }
    public static IFunction operator -(double n, IFunction f) =>
        new Constant(n) - f;
    public static IFunction operator -(IFunction f, double n) =>
        f - new Constant(n);

    #endregion

    #region Multiplication

    public static IFunction operator *(IFunction f, IFunction g) =>
        new Multiplication(f, g);
    public static IFunction operator *(double n, IFunction f) =>
        new Constant(n) * f;
    public static IFunction operator *(IFunction f, double n) =>
        f * new Constant(n);

    #endregion

    #region Division

    public static IFunction operator /(IFunction f, IFunction g) =>
        new Multiplication(f, g ^ -1);
    public static IFunction operator /(double f, IFunction g) =>
        new Multiplication(new Constant(f), g ^ -1);
    public static IFunction operator /(IFunction f, double g) =>
        new Multiplication(f, (IFunction)new Constant(g) ^ -1);

    #endregion

    #region Exponentiation
    public static IFunction operator ^(IFunction a, IFunction u)
    {
        if (a is Exponentiation pow)
        {
            pow.Add(u);

            return pow;
        }

        return new Exponentiation(a, u);
    }
    public static IFunction operator ^(double a, IFunction u) =>
        new Constant(a) ^ u;
    public static IFunction operator ^(IFunction a, double u) =>
        a ^ new Constant(u);

    #endregion

    #region Root

    public static IFunction operator |(IFunction a, IFunction u) =>
        new Exponentiation(a, 1 / u);
    public static IFunction operator |(double a, IFunction u) =>
        new Constant(a) | u;
    public static IFunction operator |(IFunction a, double u) =>
        a | new Constant(u);

    #endregion
}