using System.Linq;
using System.Text;

namespace AlgebraicSharp.Matrix;

using Functions;

public abstract class PredeterminedMatrix : Matrix
{
    protected abstract IFunction value { get; set; }

    public new IFunction this[int row, int col]
    {
        get
        {
            if (row < 0 || row > Rows ||
                col < 0 || col > Columns)
                throw new System.IndexOutOfRangeException();

            if (value == null)
                throw new System.NullReferenceException();
            
            return value;
        }
    }


    public abstract Matrix Derive();

    public abstract Matrix Integrate();

    public abstract Matrix Simplify();

    public override string ToString()
    {
        int
            count = Rows.ToString().Length + Columns.ToString().Length + 5,
            middle = Rows / 2;

        if (Rows % 2 == 0)
            middle--;
        
        StringBuilder matrix = new();

        for (int i = 0; i < Rows; i++)
        {
            string
                space = i == middle ? $"{Symbol}{Rows}x{Columns} = " : new string(' ', count),
                row = "|" + string.Join(' ', Enumerable.Repeat(value.ToString(), Columns)) + "|",
                newLine = i == Rows - 1 ? string.Empty : "\n";

            matrix.Append(space + row + newLine);
        }

        return matrix.ToString();
    }
}