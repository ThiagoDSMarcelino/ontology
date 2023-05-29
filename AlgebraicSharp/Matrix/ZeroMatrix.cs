namespace AlgebraicSharp.Matrix;

using Functions;

public class ZeroMatrix : PredeterminedMatrix
{
    public override char Symbol { get; set; } = '0';
    protected override IFunction value { get; set; } = new Constant(0);

    internal ZeroMatrix(int row, int columns)
    {
        Row = row;
        Columns = columns;
    }
    internal ZeroMatrix(int row, int columns, char symbol)
    {
        Row = row;
        Columns = columns;
        Symbol = symbol;
    }

    public new IMatrix this[double x] =>
        this;

    public override IMatrix Derive() =>
        this;

    public override IMatrix Integrate() =>
        throw new System.NotImplementedException();

    public override IMatrix Simplify() =>
        throw new System.NotImplementedException();
}