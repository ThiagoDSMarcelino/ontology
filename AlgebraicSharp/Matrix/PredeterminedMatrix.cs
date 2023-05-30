using System.Linq;

namespace AlgebraicSharp.Matrix;

public abstract class PredeterminedMatrix : Matrix
{
    protected abstract double value { get; }

    public override double this[int row, int col]
    {
        get
        {
            if (row < 0 || row > Rows)
                throw new System.IndexOutOfRangeException(); // TODO RowOutOfRangeException

            if (col < 0 || col > Columns)
                throw new System.IndexOutOfRangeException(); // TODO ColumnOutOfRangeException

            return value;
        }
    }
    protected override string[] getRow(int index) =>
        Enumerable.Repeat(value.ToString(), Columns).ToArray();
}