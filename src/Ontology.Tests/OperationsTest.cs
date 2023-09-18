namespace Ontology.Tests;

using static Ontology.Calculus;

public class OperationsTest
{
    [Fact]
    public void Negative()
    {
        double n = 10;
        var x = CreateVariable();
        var f = -x;
        var derivate = f.Derive();

        Assert.Equal(-n, f[n]);
        Assert.Equal(-1, derivate[n]);
    }

    #region Sum Tests

    [Fact]
    public void Sum()
    {
        double n = 10;
        var x = CreateVariable();
        var f = x + x;
        var derivate = f.Derive();

        Assert.Equal(n + n, f[n]);
        Assert.Equal(2, derivate[n]);
    }

    [Fact]
    public void Sums()
    {
        double n = 10;
        var x = CreateVariable();
        var f = x + x + x + x + x;
        var derivate = f.Derive();

        Assert.Equal(n * 5, f[n]);
        Assert.Equal(5, derivate[n]);
    }

    #endregion

    #region Subtraction Tests

    [Fact]
    public void Subtraction()
    {
        double n = 10;
        var x = CreateVariable();
        var f = x - x;
        var derivate = f.Derive();

        Assert.Equal(0, f[n]);
        Assert.Equal(0, derivate[n]);
    }

    [Fact]
    public void Subtractions()
    {
        double n = 10;
        var x = CreateVariable();
        var f = x - x - x - x - x;
        var derivate = f.Derive();

        Assert.Equal(-n * 3, f[n]);
        Assert.Equal(-3, derivate[n]);
    }

    #endregion

    #region Multiplication Tests

    [Fact]
    public void Multiplication()
    {
        double n = 10;
        var x = CreateVariable();
        var f = x * x;
        var derivate = f.Derive();

        Assert.Equal(n * n, f[n]);
        Assert.Equal(n + n, derivate[n]);
    }

    [Fact]
    public void Multiplications()
    {
        double n = 10;
        var x = CreateVariable();
        var f = x * x * x * x * x;
        var derivate = f.Derive();

        Assert.Equal(Math.Pow(n, 5), f[n]);
        Assert.Equal(5 * Math.Pow(n, 4), derivate[n]);
    }

    #endregion

    #region Division Tests

    [Fact]
    public void Division()
    {
        double n = 10;
        var x = CreateVariable();
        var f = x / x;
        var derivate = f.Derive();

        Assert.Equal(n / n, f[n]);
        Assert.Equal(0, derivate[n]);
    }

    [Fact]
    public void Divisions()
    {
        double n = 10;
        var x = CreateVariable();
        var f = x / x / x;
        var derivate = f.Derive();

        Assert.Equal(n / n / n, f[n]);
        Assert.Equal(-1/(n * n), derivate[n]);
    }

    #endregion
}