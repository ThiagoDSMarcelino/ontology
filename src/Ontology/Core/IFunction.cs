namespace Ontology;

using Operations;
using static Calculus;

public interface IFunction
{
    double this[double x] { get; }

    IFunction Derive();

    public static IFunction operator -(IFunction f)
        => new Negative(f);

    #region Sum

    public static IFunction operator +(IFunction f, IFunction g)
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

    public static IFunction operator +(double n, IFunction f)
        => CreateConstant(n) + f;
    public static IFunction operator +(IFunction f, double n)
        => f + CreateConstant(n);

    #endregion

    #region Subtraction

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
    public static IFunction operator -(double n, IFunction f)
        => CreateConstant(n) - f;
    public static IFunction operator -(IFunction f, double n)
        => f - CreateConstant(n);

    #endregion

    #region Multiplication

    public static IFunction operator *(IFunction f, IFunction g)
        => new Multiplication(f, g);
    public static IFunction operator *(double n, IFunction f)
        => CreateConstant(n) * f;
    public static IFunction operator *(IFunction f, double n)
        => f * CreateConstant(n);

    #endregion

    #region Division

    public static IFunction operator /(IFunction f, IFunction g)
        => new Multiplication(f, Pow(g, -1));
    public static IFunction operator /(double f, IFunction g)
        => CreateConstant(f) / g;
    public static IFunction operator /(IFunction f, double g)
        => f / CreateConstant(g);

    #endregion
}