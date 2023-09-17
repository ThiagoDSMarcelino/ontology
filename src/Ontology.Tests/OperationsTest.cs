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
    public void SingleSum()
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
}