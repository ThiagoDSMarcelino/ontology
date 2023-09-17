namespace Ontology;

using Functions.Trigonometry.ReciprocalIdentities;
using Functions.Trigonometry.Inverse;
using Functions;
using Ontology.Operations;

public static class Calculus
{
    public static IFunction CreateVariable()
        => new Linear();

    public static IFunction CreateConstant(double k)
        => new Constant(k);

    #region Constants

    private static Constant euler = null;
    public static IFunction E
    {
        get
        {
            euler ??= new(Math.E);

            return euler;
        }
    }

    private static Constant pi = null;
    public static IFunction PI
    {
        get
        {
            pi ??= new(Math.PI);

            return pi;
        }
    }

    #endregion

    #region Logarithms

    public static IFunction Ln(IFunction u)
        => new NaturalLogarithm(u);

    public static IFunction Ln(double u)
        => Ln(CreateConstant(u));

    public static IFunction Log(IFunction u, IFunction newBase)
        => new Logarithm(u, newBase);

    public static IFunction Log(IFunction u, double newBase)
        => Log(u, CreateConstant(newBase));

    public static IFunction Log(double u, IFunction newBase)
        => Log(CreateConstant(u), newBase);

    public static IFunction Log(double u, double newBase)
        => Log(CreateConstant(u), CreateConstant(newBase));

    #endregion

    #region Trigonometry

    #region Reciprocal Identities

    public static IFunction Sin(double u)
        => Sin(CreateConstant(u));

    public static IFunction Sin(IFunction u)
        => new Sine(u);

    public static IFunction Cos(double u)
        => Cos(CreateConstant(u));

    public static IFunction Cos(IFunction u)
        => new Cosine(u);

    public static IFunction Tg(double u)
        => Tg(CreateConstant(u));

    public static IFunction Tg(IFunction u)
        => new Tangent(u);

    public static IFunction Sec(double u)
        => Sec(CreateConstant(u));

    public static IFunction Sec(IFunction u)
        => new Secant(u);

    public static IFunction Csc(double u)
        => Csc(CreateConstant(u));

    public static IFunction Csc(IFunction u)
        => new Cosecant(u);

    public static IFunction Cot(double u)
        => Cot(CreateConstant(u));

    public static IFunction Cot(IFunction u)
        => new Cotangent(u);

    #endregion

    #region Inverse Identities

    public static IFunction ArcSine(double u)
        => ArcSine(CreateConstant(u));

    public static IFunction ArcSine(IFunction u)
        => new InverseSine(u);

    public static IFunction ArcCosine(double u)
        => ArcCosine(CreateConstant(u));

    public static IFunction ArcCosine(IFunction u)
        => new InverseCosine(u);

    public static IFunction ArcTg(double u)
        => ArcTg(CreateConstant(u));

    public static IFunction ArcTg(IFunction u)
        => new InverseTangent(u);

    public static IFunction ArcSec(double u)
        => ArcSec(CreateConstant(u));

    public static IFunction ArcSec(IFunction u)
        => new InverseSecant(u);

    public static IFunction ArcCsc(double u)
        => ArcCsc(CreateConstant(u));

    public static IFunction ArcCsc(IFunction u)
        => new InverseCosecant(u);

    public static IFunction ArcCot(double u)
        => ArcCot(CreateConstant(u));

    public static IFunction ArcCot(IFunction u)
        => new InverseCotangent(u);

    #endregion

    #endregion

    #region Operations

    public static IFunction Pow(IFunction f, IFunction g)
    {
        if (f is Exponentiation pow)
        {
            pow.Add(g);

            return pow;
        }

        return new Exponentiation(f, g);
    }

    public static IFunction Pow(double f, IFunction g)
        => Pow(CreateConstant(f), g);

    public static IFunction Pow(IFunction f, double g)
        => Pow(f, CreateConstant(g));
    
    public static IFunction Pow(double f, double g)
        => Pow(CreateConstant(f), CreateConstant(g));

    public static IFunction Sqrt(IFunction f, IFunction g)
        => new Exponentiation(f, 1 / g);

    public static IFunction Sqrt(double f, IFunction g)
        => Sqrt(CreateConstant(f), g);

    public static IFunction Sqrt(IFunction f, double g)
        => Sqrt(f, CreateConstant(g));
    
    public static IFunction Sqrt(double f, double g)
        => Sqrt(CreateConstant(f), CreateConstant(g));

    #endregion
}