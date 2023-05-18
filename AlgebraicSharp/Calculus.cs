using System;

namespace AlgebraicSharp;

public static class Calculus
{
    private static Linear linear = null;
    public static IFunction x
    {
        get
        {
            linear ??= new Linear();

            return linear;
        }
    }

    private static Constant euler = null;
    public static IFunction e
    {
        get
        {
            euler ??= new Constant(Math.E);

            return euler;
        }
    }

    public static IFunction sin(IFunction f) =>
        new Sin(f);

    public static IFunction cos(IFunction f) =>
        new Cos(f);
}