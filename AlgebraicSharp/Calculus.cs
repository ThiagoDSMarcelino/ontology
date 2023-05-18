using System;

namespace AlgebraicSharp;

public static class Calculus
{
    private static Linear linear = null;
    public static IFunction x
    {
        get
        {
            linear ??= new();

            return linear;
        }
    }

    private static Constant euler = null;
    public static IFunction e
    {
        get
        {
            euler ??= new(Math.E);

            return euler;
        }
    }

    public static IFunction sin(IFunction u) =>
        new Sin(u);

    public static IFunction cos(IFunction u) =>
        new Cos(u);
}