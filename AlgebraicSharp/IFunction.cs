namespace AlgebraicSharp;

using Operations;
using Functions;

public interface IFunction
{
    double this[double x] { get; }

    IFunction Derive();
    IFunction Integrate();
    IFunction Simplify();

    #region Sum

    public static IFunction operator +(IFunction f, IFunction g)
    {
        if (f.GetType() == typeof(Sum))
        {
            var temp = (Sum)f;
            temp.Add(g);

            return temp;
        }
        else if (g.GetType() == typeof(Sum))
        {
            var temp = (Sum)g;
            temp.Add(f);

            return temp;
        }

        return new Sum(f, g);
    }
    public static IFunction operator +(double n, IFunction f)
    {
        if (f.GetType() == typeof(Sum))
        {
            var temp = (Sum)f;
            temp.Add(new Constant(n));

            return temp;
        }

        return new Sum(f, new Constant(n));
    }
    public static IFunction operator +(IFunction f, double n)
    {
        if (f.GetType() == typeof(Sum))
        {
            var temp = (Sum)f;
            temp.Add(new Constant(n));

            return temp;
        }

        return new Sum(f, new Constant(n));
    }

    #endregion

    #region Sub

    public static IFunction operator -(IFunction f) =>
        new Negative(f);
    public static IFunction operator -(IFunction f, IFunction g)
    {
        if (f.GetType() == typeof(Subtraction))
        {
            var temp = (Subtraction)f;
            temp.Add(g);

            return temp;
        }
        else if (g.GetType() == typeof(Subtraction))
        {
            var temp = (Subtraction)g;
            temp.Add(f);

            return temp;
        }

        return new Subtraction(f, g);
    }
    public static IFunction operator -(double n, IFunction f)
    {
        if (f.GetType() == typeof(Subtraction))
        {
            var temp = (Subtraction)f;
            temp.Add(new Constant(n));

            return temp;
        }

        return new Subtraction(f, new Constant(n));
    }
    public static IFunction operator -(IFunction f, double n)
    {
        if (f.GetType() == typeof(Subtraction))
        {
            var temp = (Subtraction)f;
            temp.Add(new Constant(n));

            return temp;
        }

        return new Subtraction(f, new Constant(n));
    }

    #endregion

    #region Multiplication

    public static IFunction operator *(IFunction f, IFunction g)
    {
        if (f.GetType() == typeof(Multiplication))
        {
            var temp = (Multiplication)f;
            temp.Add(g);

            return temp;
        }
        else if (g.GetType() == typeof(Multiplication))
        {
            var temp = (Multiplication)g;
            temp.Add(f);

            return temp;
        }
        
        return new Multiplication(f, g);
    }
    public static IFunction operator *(double n, IFunction f)
    {
        if (f.GetType() == typeof(Multiplication))
        {
            var temp = (Multiplication)f;
            temp.Add(new Constant(n));

            return temp;
        }

        return new Multiplication(f, new Constant(n));
    }
    public static IFunction operator *(IFunction f, double n)
    {
        if (f.GetType() == typeof(Multiplication))
        {
            var temp = (Multiplication)f;
            temp.Add(new Constant(n));

            return temp;
        }

        return new Multiplication(f, new Constant(n));
    }

    #endregion

    #region Division

    public static IFunction operator /(IFunction f, IFunction g) =>
        new Multiplication(f, g ^ -1);
    public static IFunction operator /(double f, IFunction g) =>
        new Multiplication(new Constant(f), g ^ -1);
    public static IFunction operator /(IFunction f, double g) =>
        new Multiplication(f, (IFunction)new Constant(g) ^ -1);

    #endregion

    #region Pow

    public static IFunction operator ^(IFunction a, IFunction u) =>
        new Pow(a, u);
    public static IFunction operator ^(double a, IFunction u) =>
        new Pow(new Constant(a), u);
    public static IFunction operator ^(IFunction a, double u) =>
        new Pow(a, new Constant(u));

    #endregion
}