namespace AlgebraicSharp.Matrix;

public class UnitMatrix : PredeterminedMatrix
{
    public override char Symbol { get; set; }

    protected override double value => 0;

    internal UnitMatrix(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
    }
    internal UnitMatrix(int rows, int columns, char symbol)
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