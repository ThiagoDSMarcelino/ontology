using static System.Math;
using System.Linq;

namespace AlgebraicSharp;

using Functions.Trigonometry.ReciprocalIdentities;
using Functions.Trigonometry.Inverse;
using Functions;

#pragma warning disable IDE1006

public static class Calculus
{
    #region Linear

    private static Linear linear = null;
    public static IFunction x
    {
        get
        {
            linear ??= new();

            return linear;
        }
    }
    public static IFunction y
    {
        get
        {
            linear ??= new();

            return linear;
        }
    }

    #endregion

    #region Constants

    private static Constant euler = null;
    public static IFunction e
    {
        get
        {
            euler ??= new(E);

            return euler;
        }
    }

    private static Constant pi = null;
    public static IFunction Pi
    { 
        get
        {
            pi ??= new(PI);

            return pi;
        }
    }

    #endregion

    #region Functions

    #region Natural Logarithm

    public static IFunction ln(IFunction u) =>
        new Logarithm(u, e);

    public static IFunction ln(double u) =>
        new Logarithm(new Constant(u), e);

    #endregion

    #region Logarithm
    public static IFunction log(IFunction u) =>
        new Logarithm(u, new Constant(10));

    public static IFunction log(IFunction newBase, IFunction u) =>
        new Logarithm(u, newBase);

    public static IFunction log(double newBase, IFunction u) =>
        new Logarithm(u, new Constant(newBase));

    public static IFunction log(IFunction newBase, double u) =>
        new Logarithm(new Constant(u), newBase);

    public static IFunction log(double newBase, double u) =>
        new Logarithm(new Constant(u), new Constant(newBase));

    #endregion

    #region Trigonometry

    #region Reciprocal Identities

    #region Sine

    public static IFunction sin(IFunction u) =>
        new Sine(u);
    
    public static IFunction sin(double u) =>
        new Sine(new Constant(u));

    #endregion

    #region Cosine
    
    public static IFunction cos(IFunction u) =>
        new Cosine(u);
    
    public static IFunction cos(double u) =>
        new Cosine(new Constant(u));

    #endregion

    #region Tangent

    public static IFunction tg(IFunction u) =>
        new Tangent(u);
    
    public static IFunction tg(double u) =>
        new Tangent(new Constant(u));

    #endregion

    #region Secant

    public static IFunction sec(IFunction u) =>
        new Secant(u);
    
    public static IFunction sec(double u) =>
        new Secant(new Constant(u));

    #endregion

    #region Cosecant

    public static IFunction csc(IFunction u) =>
        new Cosecant(u);
    
    public static IFunction csc(double u) =>
        new Cosecant(new Constant(u));

    #endregion

    #region Cotangent

    public static IFunction cot(IFunction u) =>
        new Cotangent(u);

    public static IFunction cot(double u) =>
        new Cotangent(new Constant(u));

    #endregion

    #endregion

    #region Inverse

    #region Inverse Sine

    public static IFunction arcsin(IFunction u) =>
        new InverseSine(u);

    public static IFunction arcsin(double u) =>
        new InverseSine(new Constant(u));

    #endregion

    #endregion

    #endregion

    #endregion

    #region Console

    public static void WriteFunc(IFunction func, double x, int derivative = 0) =>
        System.Console.Write(GetFunc(func, x, derivative));
    public static void WriteLineFunc(IFunction func, double x, int derivative = 0) =>
        System.Console.WriteLine(GetFunc(func, x, derivative));
    public static string GetFunc(IFunction func, double x, int derivative) =>
        $"f{getDerivative(derivative)}(x) = {func}\nf{getDerivative(derivative)}({x}) = {func[x]}";
    private static string getDerivative(int derivative) =>
        string.Join("", Enumerable.Range(0, derivative).Select(x => "'").ToArray());

    #endregion
}

#pragma warning restore IDE1006