using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace AlgebraicSharp.Matrix;

using Functions;

public abstract class Matrix : ICalculus<Matrix>, IEnumerable<IFunction>
{
    public int Rows { get; protected set; }

    public int Columns { get; protected set; }
    
    public abstract char Symbol { get; set; }

    public virtual double this[int row, int col] =>
        throw new System.NotImplementedException();

    protected abstract string[] getRow(int index);

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

        StringBuilder matrix = new(Rows * (count + Columns + 2));

        for (int i = 0; i < Rows; i++)
        {
            string
                space = i == middle ? $"{Symbol}{Rows}x{Columns} = " : new string(' ', count),
                row = "|" + string.Join(' ', getRow(i)) + "|",
                newLine = i == Rows - 1 ? string.Empty : "\n";

            matrix.Append(space + row + newLine);
        }

        return matrix.ToString();
    }

    public IEnumerator<IFunction> GetEnumerator() =>
        throw new System.NotImplementedException();

    IEnumerator IEnumerable.GetEnumerator() =>
        throw new System.NotImplementedException();
}