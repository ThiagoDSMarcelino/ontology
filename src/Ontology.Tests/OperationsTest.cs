namespace Ontology.Tests;

using static Ontology.Calculus;

public class OperationsTest
{
    public static TheoryData<int> Data()
    {
        var data = new TheoryData<int>
        {
            10,
            5,
            1,
            900000
        };

        return data;
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Negative(double n)
    {
        var x = CreateVariable();
        var f = -x;
        var derivate = f.Derive();

        Assert.Equal(-n, f[n]);
        Assert.Equal(-1, derivate[n]);
    }

    #region Sum Tests

    [Theory]
    [MemberData(nameof(Data))]
    public void Sum(double n)
    {
        var x = CreateVariable();
        var f = x + x;
        var derivate = f.Derive();

        Assert.Equal(n + n, f[n]);
        Assert.Equal(2, derivate[n]);
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Sums(double n)
    {
        var x = CreateVariable();
        var f = x + x + x + x + x;
        var derivate = f.Derive();

        Assert.Equal(n * 5, f[n]);
        Assert.Equal(5, derivate[n]);
    }

    #endregion

    #region Subtraction Tests

    [Theory]
    [MemberData(nameof(Data))]
    public void Subtraction(double n)
    {
        var x = CreateVariable();
        var f = x - x;
        var derivate = f.Derive();

        Assert.Equal(0, f[n]);
        Assert.Equal(0, derivate[n]);
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Subtractions(double n)
    {
        var x = CreateVariable();
        var f = x - x - x - x - x;
        var derivate = f.Derive();

        Assert.Equal(-n * 3, f[n]);
        Assert.Equal(-3, derivate[n]);
    }

    #endregion

    #region Multiplication Tests

    [Theory]
    [MemberData(nameof(Data))]
    public void Multiplication(double n)
    {
        var x = CreateVariable();
        var f = x * x;
        var derivate = f.Derive();

        Assert.Equal(n * n, f[n]);
        Assert.Equal(n + n, derivate[n]);
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Multiplications(double n)
    {
        var x = CreateVariable();
        var f = x * x * x * x * x;
        var derivate = f.Derive();

        double expected = Math.Pow(n, 5);
        double actual = f[n];
        double tolerance = Math.Max(Math.Abs(expected), Math.Abs(actual)) * 1e-15;

        Assert.Equal(expected, actual, tolerance);
        Assert.Equal(5 * Math.Pow(n, 4), derivate[n]);
    }

    #endregion

    #region Division Tests

    [Theory]
    [MemberData(nameof(Data))]
    public void Division(double n)
    {
        var x = CreateVariable();
        var f = x / x;
        var derivate = f.Derive();

        double expected = n / n;
        double actual = f[n];
        double tolerance = Math.Max(Math.Abs(expected), Math.Abs(actual)) * 1e-15;

        Assert.Equal(expected, actual, tolerance);
        Assert.Equal(0, derivate[n]);
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Divisions(double n)
    {
        var x = CreateVariable();
        var f = x / x / x;
        var derivate = f.Derive();

        double expected = n / n / n;
        double expectedDerivate = -1 / (n * n);
        double actual = f[n];
        double actualDerivate = derivate[n];
        double tolerance = Math.Max(Math.Abs(expected), Math.Abs(actual)) * 1e-15;
        double toleranceDerivate = Math.Max(Math.Abs(expectedDerivate), Math.Abs(actualDerivate)) * 1e-15;

        Assert.Equal(expected, actual, tolerance);
        Assert.Equal(expectedDerivate, actualDerivate, toleranceDerivate);
    }

    #endregion
}