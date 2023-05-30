using System.Linq;
using System.Text;

namespace AlgebraicSharp.Matrix;

using Functions;

public abstract class PredeterminedMatrix : Matrix
{
    protected abstract IFunction value { get; set; }

    public new IFunction this[int row, int col] =>
        value;

    public abstract override IMatrix Derive();

    public abstract override IMatrix Integrate();

    public abstract override IMatrix Simplify();

    public override string ToString()
    {
        var count = Row.ToString().Length + Columns.ToString().Length + 5;
        StringBuilder matrix = new(count + Row + 2);

        for (int i = 0; i < Columns; i++)
        {
            var space = i != Row / 2 ? new string(' ', count) : $"{Symbol}{Row}x{Columns} = ";
            var row = "|" + string.Join(' ', Enumerable.Repeat(value.ToString(), Row)) + "|";
            var newLine = i == Columns - 1 ? string.Empty : "\n";

            matrix.Append(space + row + newLine);
        }

        return matrix.ToString();
    }
}