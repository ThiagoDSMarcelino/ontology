namespace AlgebraicSharp.Matrix;

using Functions;

public class ZeroMatrix : PredeterminedMatrix
{
    public override char Symbol { get; set; } = '0';
    protected override IFunction value { get; set; } = new Constant(0);

    internal ZeroMatrix(int row, int columns)
    {
        Rows = row;
        Columns = columns;
    }
    internal ZeroMatrix(int row, int columns, char symbol)
    {
        Rows = row;
        Columns = columns;
        Symbol = symbol;
    }

    public new Matrix this[double x] =>
        this;

    public override Matrix Derive() =>
        this;

    public override Matrix Integrate() =>
        throw new System.NotImplementedException();

    public override Matrix Simplify() =>
        throw new System.NotImplementedException();
}