﻿namespace AlgebraicSharp.Funtions;

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
        new Quotient(f, g);
    public static IFunction operator /(double n, IFunction g) =>
        new Quotient(new Constant(n), g);
    public static IFunction operator /(IFunction f, double n) =>
        new Quotient(f, new Constant(n));

    #endregion

    #region Pow

    public static IFunction operator ^(IFunction a, IFunction u) =>
        new Pow(a, u);

    #endregion
}