namespace AlgebraicSharp.Matrix;

public class ZeroMatrix : PredeterminedMatrix
{
    public override char Symbol { get; set; } = '0';
    protected override double value { get; set; } = 0;

    internal ZeroMatrix(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
    }
    internal ZeroMatrix(int rows, int columns, char symbol)
    {
        Rows = rows;
        Columns = columns;
        Symbol = symbol;
    }

    public override Matrix Derive() =>
        this;

    public override Matrix Integrate() =>
        throw new System.NotImplementedException();

    public override Matrix Simplify() =>
        throw new System.NotImplementedException();
}