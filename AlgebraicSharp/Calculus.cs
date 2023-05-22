using System.Linq;
using System;

namespace AlgebraicSharp;

using Funtions;

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
    public static IFunction z
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

    #region Functions

    public static IFunction sin(IFunction u) =>
        new Sin(u);

    public static IFunction cos(IFunction u) =>
        new Cos(u);

    public static IFunction ln(IFunction u) =>
        new Ln(u);

    public static IFunction log(IFunction u) =>
        new Log(u, 10);

    public static IFunction log(IFunction u, double a) =>
        new Log(u, a);

    #endregion

    #region Console

    public static void WriteFunc(IFunction f, double n, int derivative = 0) =>
        Console.Write(GetFunc(f, n, derivative));
    public static void WriteLineFunc(IFunction f, double n, int derivative = 0) =>
        Console.WriteLine(GetFunc(f, n, derivative));
    public static string GetFunc(IFunction f, double n, int derivative) =>
        $"f{getDerivative(derivative)}(x) = {f}\nf{getDerivative(derivative)}({n}) = {f[n]}";
    private static string getDerivative(int derivative) =>
        string.Join("", Enumerable.Range(0, derivative).Select(x => "'").ToArray());

    #endregion
}

#pragma warning restore IDE1006